using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Program360
{
    public class Castles
    {

        private int castx = 0;
        private int casty = 0;
        private int castTax = 0;

        private int enemyx = 0;
        private int enemyy = 0;
        private int enemyTax = 0;

        private void LocationCastle(uint[,] arr)
        {
            int diff = 0;
            int bestDiff = 0;

            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                {
                    if (Convert.ToInt32(arr.GetValue(i,j)) != 0)
                    {
                        int tempMinex = i;
                        int tempMiney = j;

                        for (int k = 0; k <= arr.GetUpperBound(0); k++)
                        {
                            for (int l = 0; l <= arr.GetUpperBound(1); l++)
                            {
                                double dist = Math.Sqrt(Math.Pow(k - tempMinex, 2) + Math.Pow(l - tempMiney, 2));
                                if (Convert.ToInt32(arr.GetValue(k, l)) != 0 && dist > 3)
                                {
                                    int tempEnemx = k;
                                    int tempEnemy = l;
                                    ArrayList o = GetTax(arr, tempMinex, tempMiney, tempEnemx, tempEnemy);
                                    int tempMyTax = Convert.ToInt32(o[0]);
                                    int tempEnemTax = Convert.ToInt32(o[1]);

                                    if (tempEnemTax < tempMyTax)
                                    {
                                        diff = tempMyTax - tempEnemTax;
                                    }
                                    if (diff > bestDiff)
                                    {
                                        bestDiff = diff;
                                        castx = tempMinex;
                                        casty = tempMiney;
                                        enemyx = tempEnemx;
                                        enemyy = tempEnemy;
                                        castTax = tempMyTax;
                                        enemyTax = tempEnemTax;
                                    }
                                }
                            }
                        }
                        
                    }
                }
            }
        }
        
        private ArrayList GetTax(uint[,] arr, int x1, int y1, int x2, int y2)
        {
            ArrayList o = new ArrayList();
            int tax1 = 0;
            int tax2 = 0;
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                {
                    double dist1 = Math.Sqrt(Math.Pow(i - x1, 2) + Math.Pow(j - y1, 2));
                    double dist2 = Math.Sqrt(Math.Pow(i - x2, 2) + Math.Pow(j - y2, 2));

                    if (dist1 <= 6 || dist2 <= 6)
                    {
                        if (dist1 < dist2)
                        {
                            tax1 += Convert.ToInt32(arr.GetValue(i, j));
                        }
                        if (dist1 > dist2)
                        {
                            tax2 += Convert.ToInt32(arr.GetValue(i, j));
                        }
                    }
                }  
            }

            o.Add(tax1);
            o.Add(tax2);
            return o;

        }

        public static string Process(uint[,] grid)
        {
            Castles c = new Castles();
            c.LocationCastle(grid);
            return String.Format("Your castle at ({0},{1}) earns {2}. Your nemesis' castle at ({3},{4}) earns {5}.", c.castx, c.casty, c.castTax, c.enemyx, c.enemyy, c.enemyTax);
        }

        static void Main(string[] args)
        {
        }
    }
}

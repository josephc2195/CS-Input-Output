/*
 * Warehouse Assignment
 * Name: Joseph Chica
 * ID: 800875261
 */
using System;
using System.IO;
using System.Text;

namespace Warehouses
{
    class Inventory
    {
        static void Main(string[] args)
        {
            //paths for the files. I am on mac so they will be different for windows
            string pathForInventory = "/Users/joseph/uncc/fall2020/itcs3112/Warehouses/Inventory.txt";
            string pathForTransactions = "/Users/joseph/uncc/fall2020/itcs3112/Warehouses/Transactions.txt";

            //StreamReader will read each line and correspond a line to an int array for the warehouses
            StreamReader iReader = new StreamReader(pathForInventory);
            string atl = iReader.ReadLine();
            string[] atlStringInventory = atl.Split(',');
            int[] iAtl = Array.ConvertAll(atlStringInventory, int.Parse);

            string bal = iReader.ReadLine();
            string[] balStringInventory = bal.Split(',');
            int[] iBal = Array.ConvertAll(balStringInventory, int.Parse);

            string chi = iReader.ReadLine();
            string[] chiStringInventory = chi.Split(',');
            int[] iChi = Array.ConvertAll(chiStringInventory, int.Parse);

            string den = iReader.ReadLine();
            string[] denStringInventory = den.Split(',');
            int[] iDen = Array.ConvertAll(denStringInventory, int.Parse);

            string ely = iReader.ReadLine();
            string[] elyStringInventory = ely.Split(',');
            int[] iEly = Array.ConvertAll(elyStringInventory, int.Parse);

            string far = iReader.ReadLine();
            string[] farStringInventory = far.Split(',');
            int[] iFar = Array.ConvertAll(farStringInventory, int.Parse);

            //Creating the warehouse objects
            Warehouses Atlanta = new Warehouses("Atlanta", iAtl[0], iAtl[1], iAtl[2], iAtl[3], iAtl[4]);
            Warehouses Baltimore = new Warehouses("Baltimore", iBal[0], iBal[1], iBal[2], iBal[3], iBal[4]);
            Warehouses Chicago = new Warehouses("Chicago", iChi[0], iChi[1], iChi[2], iChi[3], iChi[4]);
            Warehouses Denver = new Warehouses("Denver", iDen[0], iDen[1], iDen[2], iDen[3], iDen[4]);
            Warehouses Ely = new Warehouses("Ely", iEly[0], iEly[1], iEly[2], iEly[3], iEly[4]);
            Warehouses Fargo = new Warehouses("Fargo", iFar[0], iFar[1], iFar[2], iFar[3], iFar[4]);

            //Displaying all starting warehouse inventory
            Atlanta.displayStartingInv();
            Baltimore.displayStartingInv();
            Chicago.displayStartingInv();
            Denver.displayStartingInv();
            Ely.displayStartingInv();
            Fargo.displayStartingInv();

            //Streamreader to read the transaction files. 
            StreamReader tReader = new StreamReader(pathForTransactions);
            //string transactions = tReader.ReadToEnd();

            string strPurchase;
            string[] purchaseArray = new string[3];
            string strSale;
            string[] saleArray = new string[3];
            string item;
            int amount;
            for (int i = 0; i < 20; i++)
            {
                if(Convert.ToChar(tReader.Peek()) == 'P')
                {
                    strPurchase = tReader.ReadLine();
                    purchaseArray = strPurchase.Split(',');
                    item = purchaseArray[1];
                    amount = int.Parse(purchaseArray[2]);
                }

                else
                {
                    strSale = tReader.ReadLine();
                    saleArray = strSale.Split(',');
                    item = saleArray[1];
                    amount = int.Parse(saleArray[2]);
                }
            }
            Console.ReadLine();
        }
    }
}

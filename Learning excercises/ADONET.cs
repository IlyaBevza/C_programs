using System;
using System.Configuration;
using System.Data.Common;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using AutoLotConnectedLayer;

namespace Tests
{
    partial class Program
    {
        private static void ManipulatingDatabases()
        {
            Console.WriteLine("****The AutoLot Console UI****\n");
            string ConnStr = ConfigurationManager.ConnectionStrings["AutoLotSqlProvider"].ConnectionString;
            bool userDone = false;
            string UserCommand = string.Empty;
            InventoryDAL inv = new InventoryDAL();
            inv.OpenConnection(ConnStr);
            try
            {
                ShowInstructions();
                while (!userDone)
                {
                    Console.WriteLine("\nPlease, enter your command:");
                    UserCommand = Console.ReadLine();
                    Console.WriteLine();
                    switch (UserCommand.ToUpper())
                    {
                        case "I": InsertNewCar(ref inv); break;
                        case "U": UpdateCar(ref inv); break;
                        case "D": DeleteCar(ref inv); break;
                        case "L": ListAllCars(ref inv); break;
                        case "S": ShowInstructions(); break;
                        case "P": LookUpPetName(ref inv); break;
                        case "Q": userDone = true; break;
                        default: Console.WriteLine("Bad data! Try again"); break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (inv != null) inv.CloseConnection();
            }
        }

        //Используется конфигурационный файл
        private static void SetCommonConnection()
        {
            string dp = ConfigurationManager.AppSettings["provider"];
            string cnStr = ConfigurationManager.AppSettings["cnStr"];
            DbProviderFactory df = DbProviderFactories.GetFactory(dp);

            using (DbConnection cn = df.CreateConnection())
            {
                Console.WriteLine("Your connection object is {0}", cn.GetType().Name);
                cn.ConnectionString = cnStr;
                cn.Open();

                DbCommand cmd = df.CreateCommand();
                Console.WriteLine("Your command object is {0}", cmd.GetType().Name);
                cmd.Connection = cn;
                cmd.CommandText = "Select * From dbo.Inventory";

                using (DbDataReader dr = cmd.ExecuteReader())
                {
                    Console.WriteLine("Your data reader object is {0}", dr.GetType().Name);
                    Console.WriteLine("\n****Current inventory****");
                    while (dr.Read())
                        Console.WriteLine("->Car #{0} is {1}.", dr["CarID"], dr["Make"].ToString());
                }

            }
        }

        private static void SetConnectionWithDataReader()
        {
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AutoLot;Integrated Security=True;Connect Timeout=30";
                cn.Open();
                string SQLQuery = "Select * FROM dbo.Inventory";
                SqlCommand cmd = new SqlCommand(SQLQuery, cn);
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Console.WriteLine("Make:{0}, Petname:{1}, Color:{2}", dr["Make"].ToString(), dr["PetName"].ToString(), dr["Color"].ToString());
                    }
                }
            }

        }
        private static void ShowInstructions()
        {
            Console.WriteLine("I: Inserts new car");
            Console.WriteLine("U: Updates an existing car");
            Console.WriteLine("D: Deletes an existing car");
            Console.WriteLine("L: List an existing inventory");
            Console.WriteLine("S: Shows these instructions");
            Console.WriteLine("P: Looks up pet name");
            Console.WriteLine("Q: Quites program");
        }
        private static void ListAllCars(ref InventoryDAL inv)
        {
            DataTable dt = inv.GetAllInventoryAsATable();
            DisplayTable(ref dt);
        }
        private static void DisplayTable(ref DataTable dt)
        {
            for (int currColumn = 0; currColumn < dt.Columns.Count; currColumn++)
                Console.Write(dt.Columns[currColumn].ColumnName + "\t");
            Console.WriteLine("\n---------------------------------------");
            for (int currRow = 0; currRow < dt.Rows.Count; currRow++)
            {
                for (int currColumn = 0; currColumn < dt.Columns.Count; currColumn++)
                    Console.Write(dt.Rows[currRow][currColumn].ToString() + "\t");
                Console.WriteLine();
            }

        }
        private static void DeleteCar(ref InventoryDAL inv)
        {
            Console.Write("Enter car ID to delete:");
            int id = Convert.ToInt32(Console.ReadLine());
            try
            {
                inv.DeleteCar(id);
                Console.WriteLine("The record has been deleted");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        private static void InsertNewCar(ref InventoryDAL inv)
        {
            string newMake, newPetName, newColor;
            Console.Write("Enter car make: ");
            newMake = Console.ReadLine();
            Console.Write("\nEnter car pet name: ");
            newPetName = Console.ReadLine();
            Console.Write("\nEnter colour of car: ");
            newColor = Console.ReadLine();
            inv.InsertAuto(newMake, newPetName, newColor);

        }
        private static void UpdateCar(ref InventoryDAL inv)
        {
            int carID;
            Console.Write("Enter car ID: ");
            try
            {
                carID = Convert.ToInt32(Console.ReadLine());
                string newPetName;
                Console.Write("\nEnter new pet name: ");
                newPetName = Console.ReadLine();
                inv.UpdateCarName(carID, newPetName);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        private static void LookUpPetName(ref InventoryDAL inv)
        {
            Console.Write("Enter car ID: ");
            int carID;
            try
            {
                carID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The pet name of {0} is {1}", carID, inv.LookUpPetName(carID).Trim());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        //Автономное подключение ADO
        private static void FillDataSet(DataSet dataset)
        {
            DataColumn carIDCloumn = new DataColumn("CarID", typeof(int));
            carIDCloumn.ReadOnly = true;
            carIDCloumn.Caption = "Car ID";
            carIDCloumn.AllowDBNull = false;
            carIDCloumn.Unique = true;
            carIDCloumn.AutoIncrement = true;
            carIDCloumn.AutoIncrementSeed = 0;
            carIDCloumn.AutoIncrementStep = 1;

            DataColumn CarMakeColumn = new DataColumn("Make", typeof(string));
            DataColumn CarPetNameColumn = new DataColumn("PetName", typeof(string));
            CarPetNameColumn.Caption = "Pet name";
            DataColumn CarColorColumn = new DataColumn("Color", typeof(string));

            DataTable inventory = new DataTable("Inventory");
            inventory.Columns.AddRange(new DataColumn[] { carIDCloumn, CarMakeColumn, CarPetNameColumn, CarColorColumn });

            DataRow row = inventory.NewRow();
            row["Make"] = "BMW";
            row["PetName"] = "Hamlet";
            row["Color"] = "Black";
            row = inventory.NewRow();
            row["Make"] = "Saab";
            row["PetName"] = "Sea Breeza";
            row["Color"] = "Res";
            inventory.Rows.Add(row);

            dataset.Tables.Add(inventory);

        }
        private static void ManipulateDataRowState()
        {
            DataTable temp = new DataTable("Temp");
            DataColumn column = new DataColumn("TempColumn", typeof(int));
            temp.Columns.Add(column);
            DataRow row = temp.NewRow();
            Console.WriteLine("After calling NewRow: {0}", row.RowState);
            temp.Rows.Add(row);
            row["TempColumn"] = 10;
            Console.WriteLine("After first assignment: {0}", row.RowState);
            temp.AcceptChanges();
            Console.WriteLine("After calling AcceptChanges: {0}", row.RowState);
            row[0] = 11;
            Console.WriteLine("After first assignment: {0}", row.RowState);
            temp.Rows[0].Delete();
            Console.WriteLine("After calling Delete: {0}", row.RowState);
        }
        private static void PrintDataset(DataSet dataset)
        {
            Console.WriteLine("The name of dataset is {0}", dataset.DataSetName);
            foreach (System.Collections.DictionaryEntry entry in dataset.ExtendedProperties)
            {
                Console.WriteLine("Key={0}, value={1}", entry.Key, entry.Value);
            }
            foreach (DataTable table in dataset.Tables)
            {
                Console.WriteLine("=>{0}", table.TableName);
                for (int i = 0; i < table.Columns.Count; i++)
                    Console.Write("{0}\t", table.Columns[i].ColumnName);
                Console.WriteLine("\n-----------------------------");
                //for(int CurRow = 0; CurRow < table.Rows.Count; CurRow++)
                //{
                //    for(int CurCol=0;CurCol<table.Columns.Count;CurCol++)
                //        Console.Write(table.Rows[CurRow][CurCol].ToString()+"\t");
                //}
                //Другой вариант с использованием TableDataReader
                PrintDataReader(table);
            }

        }
        private static void PrintDataReader(DataTable table)
        {
            DataTableReader reader = new DataTableReader(table);
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                    Console.Write("{0}\t", reader.GetValue(i).ToString());
            }
            reader.Close();
        }
        private static void SaveAndLoadAsXML(DataSet dataset)
        {
            dataset.WriteXml("CarsDataSet.xml");
            dataset.WriteXmlSchema("CarsDataSet.xsd");

            dataset.Clear();

            dataset.ReadXml("CarsDataSet.xml");

        }
        private static void SaveAndLoadAsBinary(DataSet dataset)
        {
            dataset.RemotingFormat = SerializationFormat.Binary;
            FileStream fs = new FileStream("CarDataSet.bin",FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, dataset);
            fs.Close();

            dataset.Clear();

            fs = new FileStream("CarDataSet.bin", FileMode.Open);
            DataSet ds = (DataSet)bf.Deserialize(fs);
            fs.Close();
        }



    }
}
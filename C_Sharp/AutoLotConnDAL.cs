using System;
using System.Data;
using System.Data.SqlClient;
using Cars;

namespace AutoLotConnectedLayer
{
    public class InventoryDAL
    {
        private SqlConnection connection = null;
        public void OpenConnection(string ConnectionString)
        {
            connection = new SqlConnection();
            connection.ConnectionString = ConnectionString;
            connection.Open();
            
        }
        public void CloseConnection()
        {
            if(this.connection!=null)this.connection.Close();
        }
        public void InsertAuto(string Make,string PetName,string Color)
        {
            if(this.connection==null) throw new Exception ("Соединение не установлено");
            string Command = string.Format("DECLARE @maxID AS INT=(Select MAX(CarID)+1 From dbo.Inventory);" +
                "Insert INTO dbo.Inventory (CarID,Make,PetName,Color) VALUES (@maxID,@Make,@PetName,@Color)");
            using(SqlCommand cmd=new SqlCommand(Command, this.connection))
            {
                SqlParameter param = new SqlParameter("Make",Make);
                cmd.Parameters.Add(param);
                param.DbType = DbType.String;
                param.Size = 50;
                param = new SqlParameter("PetName", PetName);
                param.DbType = DbType.String;
                param.Size = 50;
                cmd.Parameters.Add(param);
                param = new SqlParameter("Color", Color);
                param.DbType = DbType.String;
                param.Size = 50;
                cmd.Parameters.Add(param);
                cmd.ExecuteNonQuery();
            }

        }
        public void InsertAuto(Car car)
        {
            if (this.connection == null) throw new Exception("Соединение не установлено");
            string Command = string.Format("Insert INTO dbo.Inventory (Make,PetName,Color)" +
                                        "VALUES ('{0}','{1}','{2}')", car.Make, car.PetName, car.Color);
            using (SqlCommand cmd = new SqlCommand(Command, this.connection))
            {
                cmd.ExecuteNonQuery();
            }
        }
        public void DeleteCar(int carID)
        {
            if (this.connection == null) throw new Exception("Соединение не установлено");
            string Command = string.Format("DELETE FROM dbo.Inventory WHERE CarID={0}", carID);
            using(SqlCommand cmd=new SqlCommand(Command, this.connection))
            {
                try { cmd.ExecuteNonQuery(); }
                catch
                {
                    throw new Exception("The car in order.");
                }
                
            }
        }
        public void UpdateCarName(int carID,string newPetName)
        {
            if (this.connection == null) throw new Exception("Соединение не установлено");
            string Command = string.Format("UPDATE dbo.Inventory SET PetName='{1}'" +
                                        "WHERE CarID={0}'",carID,newPetName);
            using (SqlCommand cmd = new SqlCommand(Command, this.connection))
            {
                cmd.ExecuteNonQuery();
            }
        }
        public DataTable GetAllInventoryAsATable()
        {
            DataTable dt = new DataTable();
            string Command = "Select * FROM dbo.Inventory";
            using(SqlCommand cmd=new SqlCommand(Command, this.connection))
            {
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dr.Close();
            }
            return dt;
        }
        public string LookUpPetName(int carID)
        {
            if (this.connection == null) throw new Exception("Closed connection.");
            string CarPetName = string.Empty;
            using (SqlCommand cmd=new SqlCommand("dbo.GetPetName",this.connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter("@CarID", carID);
                param.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(param);
                param = new SqlParameter("@PetName", SqlDbType.Char, 50);
                param.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(param);
                cmd.ExecuteNonQuery();
                CarPetName = cmd.Parameters["@PetName"].Value.ToString();
            }
            return CarPetName;
        }
    }
}

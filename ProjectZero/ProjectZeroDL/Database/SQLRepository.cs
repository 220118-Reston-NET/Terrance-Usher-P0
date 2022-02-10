using System.Data.SqlClient;
using ProjectZeroModel;

namespace ProjectZeroDL
{
    public class SQLRepository : IRepository
    {   private readonly string _connectionStrings;
        public SQLRepository(string c_connectionStrings)
        {
            _connectionStrings = c_connectionStrings;
        }

        public Cust AddCust(Cust c_cust)
        {
            
            string sqlQuery = @"insert  into Customer 
                            values(@CustName, @CustAddress, @CustNum)";

            using (SqlConnection con = new SqlConnection(_connectionStrings))
            {
                con.Open();

                SqlCommand command = new SqlCommand(sqlQuery, con);
                command.Parameters.AddWithValue("@CustName", c_cust.CustName);
                command.Parameters.AddWithValue("@CustAddress", c_cust.CustAddress);
                command.Parameters.AddWithValue("@CustNum", c_cust.CustNum);

                command.ExecuteNonQuery();

            }

            return c_cust;

        }

        public List<Cust> GetAllCust()
        {
            List<Cust> listOfCustomer  = new List<Cust>();

            string sqlQuery = @"select * from Customer";

            using (SqlConnection con = new SqlConnection(_connectionStrings))
            {

                con.Open();

                SqlCommand command = new SqlCommand(sqlQuery, con);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    listOfCustomer.Add(new Cust(){
                        CustID = reader.GetInt32(0),
                        CustName = reader.GetString(1),
                        CustAddress = reader.GetString(2),
                        CustNum = reader.GetString(3)
                    });
                }
            }

            return listOfCustomer;
        }

        public List<Store> GetAllStores()
        {
            List<Store> listOfStores = new List<Store>();

            string sqlQuery = @"select * from Store s";

            using (SqlConnection con = new SqlConnection(_connectionStrings))
            {

                con.Open();

                SqlCommand command = new SqlCommand(sqlQuery, con);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    listOfStores.Add(new Store(){
                        StoreID = reader.GetInt32(0),
                        StoreName = reader.GetString(1),
                        StoreAddress = reader.GetString(2)
                    });
                }
            }

            return listOfStores;
        }

        public int GetLastCust()
        {
            int lastCustID = 0;
            string sqlQuery = "select MAX(c.CustID) from Customer c";

            using (SqlConnection con = new SqlConnection(_connectionStrings))
            {

                con.Open();

                SqlCommand command = new SqlCommand(sqlQuery, con);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    lastCustID = reader.GetInt32(0);
                }
            }
            return lastCustID;
        }

        public List<Inv> GetStoreInv(int StoreID)
        {
            List<Inv>listOfInv = new List<Inv>();

            string sqlQuery = @"select s.StoreID ,s.StoreName ,s.StoreAddress ,si.Store_ItemID ,
                            si.Quantity ,i.ItemName ,i.ItemPrice ,i.ItemDesc ,i.ItemCate  from Store s
                            inner join Store_Item si on s.StoreID = si.StoreID 
                            inner join Item i on i.ItemID = si.ItemID 
                            where s.StoreID = @StoreID";

            using (SqlConnection con = new SqlConnection(_connectionStrings))
            {

                con.Open();

                SqlCommand command = new SqlCommand(sqlQuery, con);

                command.Parameters.AddWithValue("@StoreID", StoreID);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    listOfInv.Add(new Inv(){
                        ItemID = reader.GetInt32(3),
                        ItemQuantity = reader.GetInt32(4),
                        ItemName = reader.GetString(5),
                        ItemPrice = reader.GetDecimal(6),
                        ItemDesc = reader.GetString(7),
                        ItemCate = reader.GetString(8)
                    });
                }

                return listOfInv;

            }
        }
    }
}
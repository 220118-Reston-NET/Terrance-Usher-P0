using ProjectZeroModel;

namespace ProjectZeroDL
{
    /// <summary>
    /// 
    /// </summary>
    public interface IRepository
    {
        /// <summary>
        /// Add a customer to the database
        /// </summary>
        /// <param name="c_cust"></param>
        /// <returns> Will return the customer that was added </returns>
        Cust AddCust(Cust c_cust);

        /// <summary>
        /// Will give a list of all customers in the database
        /// </summary>
        /// <returns> A list collection of Cust objects </returns>
        List<Cust> GetAllCust();
    }
}


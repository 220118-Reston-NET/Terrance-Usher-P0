using ProjectZeroModel;

namespace ProjectZeroBL
{
    /// <summary>
    /// Business Layer is used for validating and processing data from either the user or database
    /// The kind of processing is dependent on the type of functionality
    /// </summary>
    public interface ICustomerBL
    {
        /// <summary>
        /// Will add a customer to the database
        /// </summary>
        /// <param name="c_cust"></param>
        /// <returns></returns>
        Cust AddCust(Cust c_cust);

        /// <summary>
        /// Will give a list of cust objects that are related to the searched name
        /// </summary>
        /// <param name="c_name"></param>
        /// <returns></returns>
        List<Cust> SearchCustomer(string c_name);
    }
}
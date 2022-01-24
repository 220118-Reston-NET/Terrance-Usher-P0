/*
    This Class is for the specific inventory for 1 store
*/

namespace ProjectZeroModel
{
    public class Inv : Item
    {
        private int _itemQuantity;
        public int ItemQuantity
        {
            get { return _itemQuantity; }
            set 
            { 
                if (value >=  0)
                {
                    _itemQuantity = value;
                }
                else
                {
                    throw new Exception("Item Quantity can not be less than zero!");
                }
            }
        }
        private List<int> _invList;
        public List<int> InvList
        {
            get { return _invList; }
            set { _invList = value; }
        }
        
    }

}

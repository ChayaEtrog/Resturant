using Resturant.classes;

namespace Resturant
{
    public interface IDataContext
    {
        public List<Customer> LoadData();
        public bool SaveData(List<Customer> customers);
    }
}

namespace Xendor.QueryModel.Criteria.OrderBy
{
    public class Field
    {
        public Field(string property, Order order = Order.Asc)
        {
            Property = property;
            Order = order;
        }
        public string Property { get; }
        public Order Order { get; }
    }
}
using Model = StoreModels;
using Entity = StoreDL.Entities;

namespace StoreDL
{
    public interface IMapper
    {
        Model.Customer ParseCustomer(Entity.Customer customer);
        Entity.Customer ParseCustomer(Model.Customer customer);
        Model.Location ParseLocation(Entity.Location location);
        Model.Product ParseProduct(Entity.Product product);
        Model.Order ParseOrder(Entity.Order order);
        Entity.Order ParserOrder(Model.Order order);
    }
}
using AkademiPlusCQRS.CQRSPattern.Commands;
using AkademiPlusCQRS.DAL;

namespace AkademiPlusCQRS.CQRSPattern.Handlers
{
    public class CreateProductCommandHandler
    {
        private readonly Context _context;

        public CreateProductCommandHandler(Context context)
        {
            _context = context;
        }
        public void Handle(CreateProductCommand createProductCommand)
        {
            _context.Products.Add(new Product
            {
                Name = createProductCommand.Name,
                Price = createProductCommand.Price,
                Brand = createProductCommand.Brand,
                Stock = createProductCommand.Stock,
                Category= createProductCommand.Category
                
            });
            _context.SaveChanges();
        }
    }
}

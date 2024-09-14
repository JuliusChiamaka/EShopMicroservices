using MediatR;

namespace Catalog.API.Products.CreateProduct;

public record CreateProductCommand(string Name, List<string> Category, string Description, string ImageFile, decimal Price) : IRequest<CreateProductResult>; //CreateProductCommand represents the data that we need to create a new product.
public record CreateProductResult(Guid Id); //CreateProductResult represents the response object return object,which in this case we just returned the product id.
internal class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, CreateProductResult> //dis class contains the business logic to handle create product command.
{
    public Task<CreateProductResult> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        //Business logic to create a product
        throw new NotImplementedException();
    }
}



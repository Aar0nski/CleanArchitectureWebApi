using MediatR;
using ProductManagementAPI.Domain.Entities;
using ProductManagementAPI.Domain.Interfaces;

namespace ProductManagementAPI.Application.Features.Products.Commands;

public class UpdateProductCommandHandler
    : IRequestHandler<UpdateProductCommand, Product?>
{
    private readonly IProductRepository _repository;

    public UpdateProductCommandHandler(IProductRepository repository)
    {
        _repository = repository;
    }

    public async Task<Product?> Handle(
        UpdateProductCommand request,
        CancellationToken cancellationToken)
    {
        var product = await _repository.GetByIdAsync(request.Id);

        if (product == null)
            return null;

        product.Name = request.Name;
        product.Price = request.Price;
        product.CategoryId = request.CategoryId;

        await _repository.UpdateAsync(product);

        return product;
    }
}
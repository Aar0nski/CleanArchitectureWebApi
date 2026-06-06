using MediatR;
using ProductManagementAPI.Domain.Entities;

namespace ProductManagementAPI.Application.Features.Products.Commands;

public record UpdateProductCommand(
    int Id,
    string Name,
    decimal Price,
    int CategoryId
) : IRequest<Product?>;
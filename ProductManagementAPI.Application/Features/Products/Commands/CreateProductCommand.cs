using MediatR;
using ProductManagementAPI.Domain.Entities;

namespace ProductManagementAPI.Application.Features.Products.Commands;

public record CreateProductCommand(
    string Name,
    decimal Price,
    int CategoryId
) : IRequest<Product>;
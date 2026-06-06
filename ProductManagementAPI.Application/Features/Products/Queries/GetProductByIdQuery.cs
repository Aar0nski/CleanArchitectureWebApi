using MediatR;
using ProductManagementAPI.Domain.Entities;

namespace ProductManagementAPI.Application.Features.Products.Queries;

public record GetProductByIdQuery(int Id) : IRequest<Product?>;
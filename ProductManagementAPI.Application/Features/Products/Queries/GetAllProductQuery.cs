using MediatR;
using ProductManagementAPI.Domain.Entities;

namespace ProductManagementAPI.Application.Features.Products.Queries;

public record GetAllProductsQuery() : IRequest<List<Product>>;
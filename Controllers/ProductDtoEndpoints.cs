using GitTestApi.Dtos;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
namespace GitTestApi.Controllers;

public static class ProductDtoEndpoints
{
    public static void MapProductDtoEndpoints (this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/ProductDto").WithTags(nameof(ProductDto));

        group.MapGet("/", () =>
        {
            return new [] { new ProductDto() };
        })
        .WithName("GetAllProductDtos")
        .WithOpenApi();

        group.MapGet("/{id}", (int id) =>
        {
            //return new ProductDto { ID = id };
        })
        .WithName("GetProductDtoById")
        .WithOpenApi();

        group.MapPut("/{id}", (int id, ProductDto input) =>
        {
            return TypedResults.NoContent();
        })
        .WithName("UpdateProductDto")
        .WithOpenApi();

        group.MapPost("/", (ProductDto model) =>
        {
            //return TypedResults.Created($"/api/ProductDtos/{model.ID}", model);
        })
        .WithName("CreateProductDto")
        .WithOpenApi();

        group.MapDelete("/{id}", (int id) =>
        {
            //return TypedResults.Ok(new ProductDto { ID = id });
        })
        .WithName("DeleteProductDto")
        .WithOpenApi();
    }
}

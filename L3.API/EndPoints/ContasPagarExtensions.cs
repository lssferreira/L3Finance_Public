using L3.API.EndPoints.Handlers;
using Microsoft.AspNetCore.Mvc;
using Shared.Data;
using Shared.DTOs.Requests;
using Shared.Models;

namespace L3.API.EndPoints;

public static class ContasPagarExtensions
{
    public static void MapContasPagarEndPoints(this WebApplication app)
    {
        app.MapGet("/ContasPagar", ([FromServices] DAL<ContaPagar> pDal) =>
        {
            return ContasPagarHandler.Listar(pDal);
        });

        app.MapPost("/ContasPagar", ([FromServices] DAL<ContaPagar> pDal, [FromBody] ContasPagarRequest pContaPagarRequest) =>
        {
            return ContasPagarHandler.Adicionar(pDal, pContaPagarRequest);
        });
    }
   
}

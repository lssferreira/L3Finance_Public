using Shared.Data;
using Shared.DTOs.Requests;
using Shared.DTOs.Response;
using Shared.Models;

namespace L3.API.EndPoints.Handlers;

internal static class ContasPagarHandler
{
    public static IResult Listar(DAL<ContaPagar> pDal)
    {
        var contas = pDal.Listar();

        if (contas is null)
        {
            Results.NotFound();
        }

        var listaDeContasAPagar = EntityListToResponseList(contas);
        return Results.Ok(listaDeContasAPagar);
    }

    public static IResult Adicionar(DAL<ContaPagar> pDal, ContasPagarRequest pContaPagarRequest)
    {
        var ContaPagar = new ContaPagar(pContaPagarRequest.Nome, pContaPagarRequest.ValorOriginal, pContaPagarRequest.DataVencimento, pContaPagarRequest.DataPagamento);

        pDal.Adicionar(ContaPagar);

        return Results.Created();
    }

    private static ICollection<ContasPagarResponse> EntityListToResponseList(IEnumerable<ContaPagar> listaDeContasPagar)
    {
        return listaDeContasPagar.Select(a => EntityToResponse(a)).ToList();
    }

    private static ContasPagarResponse EntityToResponse(ContaPagar pContasPagar)
    {
        return new ContasPagarResponse(pContasPagar.Nome, pContasPagar.ValorCorrigido, pContasPagar.DiasAtraso, pContasPagar.DataPagamento, pContasPagar.ValorOriginal);
    }

}
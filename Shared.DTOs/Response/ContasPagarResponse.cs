namespace Shared.DTOs.Response;

public record ContasPagarResponse(String Nome, Decimal ValorCorrigido, int DiasAtraso, DateTime DataPagamento, Decimal ValorOriginal);
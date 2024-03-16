namespace Shared.DTOs.Requests;

public record ContasPagarRequest(string Nome, decimal ValorOriginal, DateTime DataVencimento, DateTime DataPagamento);

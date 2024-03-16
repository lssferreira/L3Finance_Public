using System.ComponentModel.DataAnnotations;

namespace Shared.Models;

public class ContaPagar
{
    public ContaPagar(string nome, decimal valorOriginal, DateTime dataVencimento, DateTime dataPagamento)
    {

        Nome = nome;
        ValorOriginal = valorOriginal;
        DataVencimento = dataVencimento;
        DataPagamento = dataPagamento;

        RegraContasPagar = new RegrasContasPagar().Calcular(this);
        ValorCorrigido = RegraContasPagar.ValorCorrigido;
    }
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "O campo Nome é obrigatório.")]
    [MinLength(3, ErrorMessage = "O campo Nome deve ter no mínimo 3 caracteres.")]
    public string Nome { get; set; }
    
    [Required(ErrorMessage = "O campo Valor Original é obrigatório.")]
    [Range(0.01, double.MaxValue, ErrorMessage = "O campo Valor Original deve ser maior que zero.")]
    public Decimal ValorOriginal { get; private set; }
    public decimal ValorCorrigido { get; private set; } = 0;

    [Required(ErrorMessage = "O campo Data de Vencimento é obrigatória!")]
    [DataType(DataType.Date)]
    public DateTime DataVencimento { get; set; }
    
    [Required(ErrorMessage = "O campo Data de Pagamento é obrigatória!")]
    [DataType(DataType.Date)]
    public DateTime DataPagamento { get; set; }
    public int DiasAtraso { get => CalcularDiasAtraso(); } 
    public int? IdRegraContasPagar { get; set; }
    public virtual RegrasContasPagar RegraContasPagar { get; set; }

    private int CalcularDiasAtraso()
    {
        return  DataPagamento > DataVencimento ? (DataPagamento.Date - DataVencimento).Days : 0;
    }

}

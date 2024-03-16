namespace Shared.Models;

public class RegrasContasPagar
{
    public int Id { get; private set; }
    public virtual ContaPagar ContaPagar { get; set; }
    public decimal ValorCorrigido { get; private set; } = 0;
    public decimal MultaPercentual { get; private set; } = 0;
    public decimal MultaValor { get; private set; } = 0;
    public decimal JurosDiaPercentual { get; private set; } = 0;
    public decimal JurosDiaValor { get; private set; } = 0;
    public RegrasContasPagar Calcular(ContaPagar pTitulo)
    {

        ContaPagar = pTitulo;

        if (ContaPagar.DiasAtraso != 0)
        {
            DefinirRegraCalculo(pTitulo.DiasAtraso);
            CalcularMultaEJuros(pTitulo);
        }

        ValorCorrigido = pTitulo.ValorOriginal + MultaValor + JurosDiaValor;

        return this;
    }

    private void CalcularMultaEJuros(ContaPagar pTitulo)
    {
        MultaValor = pTitulo.ValorOriginal * (MultaPercentual / 100);
        JurosDiaValor = pTitulo.ValorOriginal * ((JurosDiaPercentual / 100) * ContaPagar.DiasAtraso);
    }

    private void DefinirRegraCalculo(int diasAtraso)
    {
        if (diasAtraso > 10)
        {
            MultaPercentual = 5;
            JurosDiaPercentual = 0.3m;
        }
        else if (diasAtraso > 3)
        {
            MultaPercentual = 3;
            JurosDiaPercentual = 0.2m;
        }
        else
        {
            MultaPercentual = 2;
            JurosDiaPercentual = 0.1m;
        }
    }
}

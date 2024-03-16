using Shared.Models;

namespace L3.Test;

public class RetornaValorCorrigido
{
    [Fact(DisplayName = "Conta Com 1 dia de Atraso - Calcula Valor Corrigido")]
    public void CalculaValorCorrigidoCom1DiaDeAtraso()
    {
        var cp = new ContaPagar("Titulo Teste", 1000, DateTime.Today, DateTime.Today.AddDays(1));
        
        Decimal valorEsperado = 1021m;
       
        Assert.Equal(cp.RegraContasPagar.ValorCorrigido, valorEsperado);
    }

    [Fact(DisplayName = "Conta Com 4 dias de Atraso - Calcula Valor Corrigido")]
    public void CalculaValorCorrigidoCom4DiaDeAtraso()
    {
        var cp = new ContaPagar("Titulo Teste", 1000, DateTime.Today, DateTime.Today.AddDays(4));
        
        Decimal valorEsperado = 1038m;

        Assert.Equal(cp.RegraContasPagar.ValorCorrigido, valorEsperado);
    }

    [Fact(DisplayName = "Conta Com 20 dias de Atraso - Calcula Valor Corrigido")]
    public void CalculaValorCorrigidoCom20DiaDeAtraso()
    {
        var cp = new ContaPagar("Titulo Teste", 1000, DateTime.Today, DateTime.Today.AddDays(20));
        
        Decimal valorEsperado = 1110m;

        Assert.Equal(cp.RegraContasPagar.ValorCorrigido, valorEsperado);
    }

    [Fact(DisplayName = "Conta Sem Atraso - Calcula Valor Corrigido")]
    public void CalculaValorCorrigidoSemAtraso()
    {
        var cp = new ContaPagar("Titulo Teste", 1000, DateTime.Today, DateTime.Today.AddDays(-1));

        Assert.Equal(cp.ValorOriginal, cp.RegraContasPagar.ValorCorrigido);
    }

}

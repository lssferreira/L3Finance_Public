namespace Shared.Data;

public class DAL<T> where T : class
{
    protected readonly L3FContext _context;

    public DAL(L3FContext context)
    {
        _context = context;
    }

    public IEnumerable<T> Listar()
    {
        return _context.Set<T>().ToList();
    }
    public void Adicionar(T objeto)
    {
        _context.Set<T>().Add(objeto);
        _context.SaveChanges();
    }
}

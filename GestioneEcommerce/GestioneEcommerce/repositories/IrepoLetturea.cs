namespace GestioneEcommerce.repositories
{
    public interface IrepoLetturea<T>
    {
        T? GetById(int id);
        T? getbyEmail(string email);

        IEnumerable<T> GetAll();
        IEnumerable<T> GetByFilter(string si, string sa);
    }
}

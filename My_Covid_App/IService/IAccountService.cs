namespace My_Covid_App.IService
{
    public interface IAccountService<T>
    {
        List<T> GetAll();

        T Get(int id);

        List<T> Get(string id);

        List<T> Delete(int id);
    }
}

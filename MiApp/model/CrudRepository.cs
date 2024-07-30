namespace MiApp.Model
{
    public abstract class CrudRepository<T> // la T fucniona para no 
                                            //expecificarle que tipo de dato sera hasta que lo usemos
    {

        //Creamos las operaciones basicas del CRUD
        public abstract void Create(T entity);
        public abstract T Read(int id);
        public abstract void Update(T entity);
        public abstract void Delete(int id);
    }
}

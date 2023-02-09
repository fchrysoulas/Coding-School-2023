using Epsilon.CodingSchool.Model;

namespace Epsilon.CodingSchool.EF.Repository;

public interface IEntityRepo<TEntity>
    where TEntity : EntityBase
{
    IEnumerable<TEntity> GetAll();
    TEntity? GetById(int id);
    void Add(TEntity entity);
    void Update(int id, TEntity entity);
    void Delete(int id);
}
namespace Dali
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Data;

    public abstract class MapperBase<T>
    {
        protected abstract T Map(IDataReader dataReader);

        protected IList<T> MapAll(IDataReader dataReader)
        {
            var result = new List<T>();

            while (dataReader.Read())
            {
                result.Add(Map(dataReader));
            }

            return result;
        }
    }
}

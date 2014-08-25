namespace Dali
{
    using System.Collections;
    using System.Collections.Generic;

    public class ReaderBase<T>
    {
        public IList<T> Read()
        {
            var result = new List<T>();

            return result;
        }
    }
}

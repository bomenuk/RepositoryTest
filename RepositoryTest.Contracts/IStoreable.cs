using System;
using System.Data;
using System.Collections;

namespace RepositoryTest
{
    public interface IStoreable<T>
    {
        T Id { get; set; }
    }
    
}
using System;
using System.Data;
using System.Collections;

namespace RepositoryTest.Contracts
{
    public interface IStoreable<T>
    {
        T Id { get; set; }
    }
    
}
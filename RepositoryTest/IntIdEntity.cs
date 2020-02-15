using RepositoryTest.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryTest
{
    public class IntIdEntity : IStoreable<int>
    {
        public int Id { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sf.Budget.Core.Interfaces
{
    /// <summary>
    /// Base interface for all entities
    /// </summary>
    public interface IEntity
    {
    }

    public interface IEntity<out TKey> : IEntity where TKey : IEquatable<TKey>
    {
        TKey Id { get; }
    }
}

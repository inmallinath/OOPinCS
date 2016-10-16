using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.BL
{
    public enum EntityStateOption
    {
        Active,
        Deleted
    }
    
    //Base class can be abstract (cannot be instantiated) or a concrete (can be instantiated (new keyword))
    //sealed class cannot be extended (cannote be inherited)
    public abstract class EntityBase
    {
        public EntityStateOption EntityState { get; set; }
        public bool HasChanges { get; set; }
        public bool IsNew { get; private set; }
        public bool IsValid
        {
            get
            {
                return true;
            }
        }
    }
}

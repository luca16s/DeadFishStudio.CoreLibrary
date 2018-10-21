﻿using System;

namespace DeadFishStudio.Domain.Core.Entity
{
    public class BaseEntity
    {
        private readonly Guid _value;

        public BaseEntity()
        {
            _value = Guid.NewGuid();
        }

        public virtual Guid Id
        {
            get { return _value; }
        }
    }
}

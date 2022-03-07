﻿using Mix.Database.EntityConfigurations.Base;
using System;

namespace Mix.Database.EntityConfigurations.POSTGRES.Base
{
    public abstract class PostgresAssociationBaseConfiguration<T, TPrimaryKey>
        : EntityBaseConfiguration<T, TPrimaryKey, PostgresDatabaseConstants>
        where TPrimaryKey : IComparable
        where T : EntityBase<TPrimaryKey>
    {
    }
}
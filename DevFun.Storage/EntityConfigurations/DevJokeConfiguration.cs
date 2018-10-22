using _4tecture.DataAccess.EntityFramework.Storages;
using DevFun.Common.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevFun.Storage.EntityConfigurations
{
    public class DevJokeConfiguration : RelationalEntityConfigurationBase<DevJoke>
    {
        public DevJokeConfiguration(ISchemaManager schemaManager) : base(schemaManager)
        {

        }

        protected override string TableName => "Joke";

        protected override void ConfigureEntity(EntityTypeBuilder<DevJoke> entity)
        {
            // Key
            entity.HasKey(e => e.Id);

            // Properties
            entity.Property(e => e.Author);
            entity.Property(e => e.Text);
            entity.Property(e => e.ImageUrl);

            // Relations

        }

    }
}

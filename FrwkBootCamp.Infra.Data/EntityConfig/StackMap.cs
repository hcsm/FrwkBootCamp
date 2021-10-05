using FrameBook.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FrameBook.Infra.Data.EntityConfig
{
    public class StackMap : IEntityTypeConfiguration<Stack>
    {
        public void Configure(EntityTypeBuilder<Stack> builder)
        {
            builder.ToTable("Stack");
            builder.HasKey(x => x.Id);
            builder.Property(p => p.Nome).IsRequired();
        }
    }
}

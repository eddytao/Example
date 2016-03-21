using System.Data.Entity.ModelConfiguration;

namespace Example.Data.Mapping
{
    public class TagMap : EntityTypeConfiguration<Core.Domain.Tag>
    {
        public TagMap()
        {
            // 主键
            //this.HasKey(t => t.ArticleId);

            // 字段
            //this.Property(t => t.Name).HasMaxLength(100).IsRequired();
            //this.Property(t => t.Content).HasMaxLength(500).IsRequired();
            //this.Property(t => t.Email).HasMaxLength(50).IsRequired();

            // 表名
            this.ToTable("Tag");

            // 关系
            //this.HasMany(t => t.Comment);
        }
    }
}

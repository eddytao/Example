using System.Data.Entity.ModelConfiguration;

namespace Example.Data.Mapping
{
    public class ExampleMap : EntityTypeConfiguration<Core.Domain.Example>
    {
        public ExampleMap()
        {
            // 主键
            this.HasKey(t => t.Id);

            // 字段
            //this.Property(t => t.Name).HasMaxLength(100).IsRequired();
            //this.Property(t => t.Content).HasMaxLength(500).IsRequired();
            //this.Property(t => t.Email).HasMaxLength(50).IsRequired();

            // 表名
            this.ToTable("Example");

            // 关系
            //一对一(1:0..1)
            //HasRequired(t => t.PhotoOf).WithOptional(t => t.Photo);  
            //HasOptional(t => t.Photo).WithRequired(t => t.PhotoOf);
            //一对一(1:1)
            //HasRequired(t => t.PhotoOf).WithRequiredDependent(t => t.Photo);
            //HasRequired(t => t.Photo).WithRequiredPrincipal(t => t.PhotoOf);
            //一对多(1:n) 设置外键
            this.HasMany(t => t.Tags).WithRequired(t=>t.Example).HasForeignKey(t=>t.ExampleId);
            //HasRequired(x => x.Blog).WithMany(x => x.Posts)
            //一对多(0..1:n)
            //HasMany(x => x.Posts).WithOptional(x => x.Blog);
            //HasOptional(x => x.Blog).WithMany(x => x.Posts) 

            //配置多对多关系 ToTable 配置生成的关联表名字 MapLeftKey默认表示调用HasMany的实体的主键
            //本例中如果不使用MapLeftKey默认生成Post_Id
            //this.HasMany(t => t.Authors).WithMany(t => t.Posts).Map(m =>
            //   {
            //        m.ToTable("PostAuthor");
            //        m.MapLeftKey("PostId");
            //        m.MapRightKey("AuthorId");
            //   });
        }
    }
}

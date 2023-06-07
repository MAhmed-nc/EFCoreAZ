using LotDetails.DataAccess.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LotDetails.DataAccess.Configuration
{
    /// <summary>
    /// Class LotTypeInd Configuration
    /// </summary>
    public class LotTypeIndConfiguration :  IEntityTypeConfiguration<LotType>
    {
        public LotTypeIndConfiguration() { }

        public void Configure(EntityTypeBuilder<LotType> builder)
        {
            builder.HasKey(x => x.LotTypeInd);
            builder.Property(x => x.LotTypeInd).HasColumnName(@"LotTypeInd");
            builder.Property(x => x.LotTypeName).HasColumnName(@"LotTypeName").HasMaxLength(50);
        }
    }
}

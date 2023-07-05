using AwesomeNetworkProject.Models.Users;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace AwesomeNetworkProject.Configs
{
    public class FriendConfiguration : IEntityTypeConfiguration<Friend>
    {

        public void Configure(EntityTypeBuilder<Friend> builder)
        {
            builder.ToTable("UserFriends").HasKey(p => p.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
        }
    }
}

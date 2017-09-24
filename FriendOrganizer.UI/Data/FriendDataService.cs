using System;
using System.Data.Entity;
using System.Threading.Tasks;
using FriendOrganizer.DataAccess;
using FriendOrganizer.Model;

namespace FriendOrganizer.UI.Data
{
    public class FriendDataService : IFriendDataService
    {
        private Func<FriendOrganizerDbContext> _contextCreator;

        public FriendDataService(Func<FriendOrganizerDbContext> context)
        {
            _contextCreator = context;
        }
        public async Task<Friend> GetByIdAsync(int friendId)
        {
            using (var context = _contextCreator())
            {
                return await context.Friends.AsNoTracking().SingleAsync(f => f.Id == friendId);
            }
        }
    }
}

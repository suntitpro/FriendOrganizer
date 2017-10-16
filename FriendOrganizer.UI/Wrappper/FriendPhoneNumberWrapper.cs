using FriendOrganizer.Model;

namespace FriendOrganizer.UI.Wrappper
{
    public class FriendPhoneNumberWrapper : ModelWrapper<FriendPhoneNumber>
    {
        public FriendPhoneNumberWrapper(FriendPhoneNumber friend) : base(friend)
        {
        }

        public string Number
        {
            get => GetValue<string>();
            set => SetValue(value);
        }
    }
}

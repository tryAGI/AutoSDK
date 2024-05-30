//HintName: G.Models.UserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of user. Possible values are:  
    ///   
    /// * admin — Twitch administrator
    /// * global\_mod
    /// * staff — Twitch staff
    /// * "" — Normal user
    /// </summary>
    public enum UserType
    {
        /// <summary>
        /// 
        /// </summary>
        Admin,
        /// <summary>
        /// 
        /// </summary>
        GlobalMod,
        /// <summary>
        /// 
        /// </summary>
        Staff,
    }

    public static class UserTypeExtensions
    {
        public static string ToValueString(this UserType value)
        {
            return value switch
            {
                UserType.Admin => "admin",
                UserType.GlobalMod => "global_mod",
                UserType.Staff => "staff",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static UserType ToEnum(string value)
        {
            return value switch
            {
                "admin" => UserType.Admin,
                "global_mod" => UserType.GlobalMod,
                "staff" => UserType.Staff,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static UserType ToEnum(int value)
        {
            return value switch
            {
                0 => UserType.Admin,
                1 => UserType.GlobalMod,
                2 => UserType.Staff,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}
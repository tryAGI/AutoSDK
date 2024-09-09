//HintName: G.Models.UserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of user. Possible values are:  <br/>
    ///   <br/>
    /// * admin — Twitch administrator<br/>
    /// * global\_mod<br/>
    /// * staff — Twitch staff<br/>
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

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
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
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserType? ToEnum(string value)
        {
            return value switch
            {
                "admin" => UserType.Admin,
                "global_mod" => UserType.GlobalMod,
                "staff" => UserType.Staff,
                _ => null,
            };
        }
    }
}
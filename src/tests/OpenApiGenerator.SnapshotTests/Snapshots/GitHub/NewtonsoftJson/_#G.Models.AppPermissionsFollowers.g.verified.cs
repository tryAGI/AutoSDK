//HintName: G.Models.AppPermissionsFollowers.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token to manage the followers belonging to a user.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AppPermissionsFollowers
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="read")]
        Read,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="write")]
        Write,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppPermissionsFollowersExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPermissionsFollowers value)
        {
            return value switch
            {
                AppPermissionsFollowers.Read => "read",
                AppPermissionsFollowers.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPermissionsFollowers ToEnum(string value)
        {
            return value switch
            {
                "read" => AppPermissionsFollowers.Read,
                "write" => AppPermissionsFollowers.Write,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}
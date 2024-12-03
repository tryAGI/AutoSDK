//HintName: G.Models.AppPermissionsStarring.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token to list and manage repositories a user is starring.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AppPermissionsStarring
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
    public static class AppPermissionsStarringExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPermissionsStarring value)
        {
            return value switch
            {
                AppPermissionsStarring.Read => "read",
                AppPermissionsStarring.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPermissionsStarring? ToEnum(string value)
        {
            return value switch
            {
                "read" => AppPermissionsStarring.Read,
                "write" => AppPermissionsStarring.Write,
                _ => null,
            };
        }
    }
}
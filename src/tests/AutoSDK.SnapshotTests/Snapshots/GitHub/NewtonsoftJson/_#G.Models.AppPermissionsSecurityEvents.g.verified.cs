//HintName: G.Models.AppPermissionsSecurityEvents.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token to view and manage security events like code scanning alerts.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AppPermissionsSecurityEvents
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
    public static class AppPermissionsSecurityEventsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPermissionsSecurityEvents value)
        {
            return value switch
            {
                AppPermissionsSecurityEvents.Read => "read",
                AppPermissionsSecurityEvents.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPermissionsSecurityEvents? ToEnum(string value)
        {
            return value switch
            {
                "read" => AppPermissionsSecurityEvents.Read,
                "write" => AppPermissionsSecurityEvents.Write,
                _ => null,
            };
        }
    }
}
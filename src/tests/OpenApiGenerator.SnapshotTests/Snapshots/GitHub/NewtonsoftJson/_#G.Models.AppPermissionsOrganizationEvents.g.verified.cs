//HintName: G.Models.AppPermissionsOrganizationEvents.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token to view events triggered by an activity in an organization.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AppPermissionsOrganizationEvents
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="read")]
        Read,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppPermissionsOrganizationEventsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPermissionsOrganizationEvents value)
        {
            return value switch
            {
                AppPermissionsOrganizationEvents.Read => "read",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPermissionsOrganizationEvents ToEnum(string value)
        {
            return value switch
            {
                "read" => AppPermissionsOrganizationEvents.Read,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}
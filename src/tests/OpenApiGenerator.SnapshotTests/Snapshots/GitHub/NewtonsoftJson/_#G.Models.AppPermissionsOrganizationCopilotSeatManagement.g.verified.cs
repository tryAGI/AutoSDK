//HintName: G.Models.AppPermissionsOrganizationCopilotSeatManagement.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token for managing access to GitHub Copilot for members of an organization with a Copilot Business subscription. This property is in beta and is subject to change.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AppPermissionsOrganizationCopilotSeatManagement
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="write")]
        Write,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppPermissionsOrganizationCopilotSeatManagementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPermissionsOrganizationCopilotSeatManagement value)
        {
            return value switch
            {
                AppPermissionsOrganizationCopilotSeatManagement.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPermissionsOrganizationCopilotSeatManagement ToEnum(string value)
        {
            return value switch
            {
                "write" => AppPermissionsOrganizationCopilotSeatManagement.Write,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}
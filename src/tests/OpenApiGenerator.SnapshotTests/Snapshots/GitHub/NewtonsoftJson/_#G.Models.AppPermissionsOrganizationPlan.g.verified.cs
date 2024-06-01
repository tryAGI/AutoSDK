//HintName: G.Models.AppPermissionsOrganizationPlan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token for viewing an organization's plan.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AppPermissionsOrganizationPlan
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
    public static class AppPermissionsOrganizationPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPermissionsOrganizationPlan value)
        {
            return value switch
            {
                AppPermissionsOrganizationPlan.Read => "read",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPermissionsOrganizationPlan ToEnum(string value)
        {
            return value switch
            {
                "read" => AppPermissionsOrganizationPlan.Read,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}
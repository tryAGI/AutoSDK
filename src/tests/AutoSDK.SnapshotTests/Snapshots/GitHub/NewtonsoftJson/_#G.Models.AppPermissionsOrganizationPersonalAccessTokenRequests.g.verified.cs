//HintName: G.Models.AppPermissionsOrganizationPersonalAccessTokenRequests.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token for viewing and managing fine-grained personal access tokens that have been approved by an organization.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AppPermissionsOrganizationPersonalAccessTokenRequests
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
    public static class AppPermissionsOrganizationPersonalAccessTokenRequestsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPermissionsOrganizationPersonalAccessTokenRequests value)
        {
            return value switch
            {
                AppPermissionsOrganizationPersonalAccessTokenRequests.Read => "read",
                AppPermissionsOrganizationPersonalAccessTokenRequests.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPermissionsOrganizationPersonalAccessTokenRequests? ToEnum(string value)
        {
            return value switch
            {
                "read" => AppPermissionsOrganizationPersonalAccessTokenRequests.Read,
                "write" => AppPermissionsOrganizationPersonalAccessTokenRequests.Write,
                _ => null,
            };
        }
    }
}
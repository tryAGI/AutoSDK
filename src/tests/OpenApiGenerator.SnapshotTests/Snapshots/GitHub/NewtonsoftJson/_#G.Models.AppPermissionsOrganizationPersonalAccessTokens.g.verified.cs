//HintName: G.Models.AppPermissionsOrganizationPersonalAccessTokens.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token for viewing and managing fine-grained personal access token requests to an organization.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AppPermissionsOrganizationPersonalAccessTokens
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
    public static class AppPermissionsOrganizationPersonalAccessTokensExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPermissionsOrganizationPersonalAccessTokens value)
        {
            return value switch
            {
                AppPermissionsOrganizationPersonalAccessTokens.Read => "read",
                AppPermissionsOrganizationPersonalAccessTokens.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPermissionsOrganizationPersonalAccessTokens? ToEnum(string value)
        {
            return value switch
            {
                "read" => AppPermissionsOrganizationPersonalAccessTokens.Read,
                "write" => AppPermissionsOrganizationPersonalAccessTokens.Write,
                _ => null,
            };
        }
    }
}
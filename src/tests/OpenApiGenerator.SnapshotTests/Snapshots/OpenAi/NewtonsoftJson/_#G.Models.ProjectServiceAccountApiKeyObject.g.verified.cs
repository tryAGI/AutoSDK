//HintName: G.Models.ProjectServiceAccountApiKeyObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type, which is always `organization.project.service_account.api_key`
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ProjectServiceAccountApiKeyObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="organization.project.service_account.api_key")]
        OrganizationProjectServiceAccountApiKey,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectServiceAccountApiKeyObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectServiceAccountApiKeyObject value)
        {
            return value switch
            {
                ProjectServiceAccountApiKeyObject.OrganizationProjectServiceAccountApiKey => "organization.project.service_account.api_key",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectServiceAccountApiKeyObject? ToEnum(string value)
        {
            return value switch
            {
                "organization.project.service_account.api_key" => ProjectServiceAccountApiKeyObject.OrganizationProjectServiceAccountApiKey,
                _ => null,
            };
        }
    }
}
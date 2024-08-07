//HintName: G.Models.ProjectApiKeyObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type, which is always `organization.project.api_key`
    /// </summary>
    public enum ProjectApiKeyObject
    {
        /// <summary>
        /// 
        /// </summary>
        OrganizationProjectApiKey,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectApiKeyObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectApiKeyObject value)
        {
            return value switch
            {
                ProjectApiKeyObject.OrganizationProjectApiKey => "organization.project.api_key",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectApiKeyObject? ToEnum(string value)
        {
            return value switch
            {
                "organization.project.api_key" => ProjectApiKeyObject.OrganizationProjectApiKey,
                _ => null,
            };
        }
    }
}
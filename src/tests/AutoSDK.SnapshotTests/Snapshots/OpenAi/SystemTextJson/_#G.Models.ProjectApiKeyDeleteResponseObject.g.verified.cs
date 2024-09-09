//HintName: G.Models.ProjectApiKeyDeleteResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProjectApiKeyDeleteResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        OrganizationProjectApiKeyDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectApiKeyDeleteResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectApiKeyDeleteResponseObject value)
        {
            return value switch
            {
                ProjectApiKeyDeleteResponseObject.OrganizationProjectApiKeyDeleted => "organization.project.api_key.deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectApiKeyDeleteResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "organization.project.api_key.deleted" => ProjectApiKeyDeleteResponseObject.OrganizationProjectApiKeyDeleted,
                _ => null,
            };
        }
    }
}
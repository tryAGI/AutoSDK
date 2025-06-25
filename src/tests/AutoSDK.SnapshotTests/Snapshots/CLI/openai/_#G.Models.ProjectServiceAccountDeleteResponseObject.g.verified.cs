//HintName: G.Models.ProjectServiceAccountDeleteResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProjectServiceAccountDeleteResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        OrganizationProjectServiceAccountDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectServiceAccountDeleteResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectServiceAccountDeleteResponseObject value)
        {
            return value switch
            {
                ProjectServiceAccountDeleteResponseObject.OrganizationProjectServiceAccountDeleted => "organization.project.service_account.deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectServiceAccountDeleteResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "organization.project.service_account.deleted" => ProjectServiceAccountDeleteResponseObject.OrganizationProjectServiceAccountDeleted,
                _ => null,
            };
        }
    }
}
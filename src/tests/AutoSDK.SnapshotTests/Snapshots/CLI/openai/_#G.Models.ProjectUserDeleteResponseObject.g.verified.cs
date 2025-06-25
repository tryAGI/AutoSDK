//HintName: G.Models.ProjectUserDeleteResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProjectUserDeleteResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        OrganizationProjectUserDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectUserDeleteResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectUserDeleteResponseObject value)
        {
            return value switch
            {
                ProjectUserDeleteResponseObject.OrganizationProjectUserDeleted => "organization.project.user.deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectUserDeleteResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "organization.project.user.deleted" => ProjectUserDeleteResponseObject.OrganizationProjectUserDeleted,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.ProjectObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type, which is always `organization.project`
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ProjectObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="organization.project")]
        OrganizationProject,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectObject value)
        {
            return value switch
            {
                ProjectObject.OrganizationProject => "organization.project",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectObject? ToEnum(string value)
        {
            return value switch
            {
                "organization.project" => ProjectObject.OrganizationProject,
                _ => null,
            };
        }
    }
}
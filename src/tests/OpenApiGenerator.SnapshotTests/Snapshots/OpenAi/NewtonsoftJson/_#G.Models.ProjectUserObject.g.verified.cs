//HintName: G.Models.ProjectUserObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type, which is always `organization.project.user`
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ProjectUserObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="organization.project.user")]
        OrganizationProjectUser,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectUserObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectUserObject value)
        {
            return value switch
            {
                ProjectUserObject.OrganizationProjectUser => "organization.project.user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectUserObject? ToEnum(string value)
        {
            return value switch
            {
                "organization.project.user" => ProjectUserObject.OrganizationProjectUser,
                _ => null,
            };
        }
    }
}
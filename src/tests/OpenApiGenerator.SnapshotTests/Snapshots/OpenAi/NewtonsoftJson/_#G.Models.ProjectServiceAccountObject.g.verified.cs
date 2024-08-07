//HintName: G.Models.ProjectServiceAccountObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type, which is always `organization.project.service_account`
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ProjectServiceAccountObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="organization.project.service_account")]
        OrganizationProjectServiceAccount,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectServiceAccountObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectServiceAccountObject value)
        {
            return value switch
            {
                ProjectServiceAccountObject.OrganizationProjectServiceAccount => "organization.project.service_account",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectServiceAccountObject? ToEnum(string value)
        {
            return value switch
            {
                "organization.project.service_account" => ProjectServiceAccountObject.OrganizationProjectServiceAccount,
                _ => null,
            };
        }
    }
}
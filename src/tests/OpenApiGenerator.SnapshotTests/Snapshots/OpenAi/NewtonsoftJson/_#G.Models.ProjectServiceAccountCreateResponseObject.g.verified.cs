//HintName: G.Models.ProjectServiceAccountCreateResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ProjectServiceAccountCreateResponseObject
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
    public static class ProjectServiceAccountCreateResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectServiceAccountCreateResponseObject value)
        {
            return value switch
            {
                ProjectServiceAccountCreateResponseObject.OrganizationProjectServiceAccount => "organization.project.service_account",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectServiceAccountCreateResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "organization.project.service_account" => ProjectServiceAccountCreateResponseObject.OrganizationProjectServiceAccount,
                _ => null,
            };
        }
    }
}
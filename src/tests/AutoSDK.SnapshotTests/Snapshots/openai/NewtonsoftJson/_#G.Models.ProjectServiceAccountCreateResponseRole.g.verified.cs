//HintName: G.Models.ProjectServiceAccountCreateResponseRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Service accounts can only have one role of type `member`
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ProjectServiceAccountCreateResponseRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="member")]
        Member,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectServiceAccountCreateResponseRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectServiceAccountCreateResponseRole value)
        {
            return value switch
            {
                ProjectServiceAccountCreateResponseRole.Member => "member",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectServiceAccountCreateResponseRole? ToEnum(string value)
        {
            return value switch
            {
                "member" => ProjectServiceAccountCreateResponseRole.Member,
                _ => null,
            };
        }
    }
}
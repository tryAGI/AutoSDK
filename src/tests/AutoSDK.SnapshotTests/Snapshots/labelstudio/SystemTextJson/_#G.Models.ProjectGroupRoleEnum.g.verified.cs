//HintName: G.Models.ProjectGroupRoleEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// * `Inherit` - Inherit<br/>
    /// * `Annotator` - Annotator<br/>
    /// * `Reviewer` - Reviewer
    /// </summary>
    public enum ProjectGroupRoleEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Annotator,
        /// <summary>
        /// 
        /// </summary>
        Inherit,
        /// <summary>
        /// 
        /// </summary>
        Reviewer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectGroupRoleEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectGroupRoleEnum value)
        {
            return value switch
            {
                ProjectGroupRoleEnum.Annotator => "Annotator",
                ProjectGroupRoleEnum.Inherit => "Inherit",
                ProjectGroupRoleEnum.Reviewer => "Reviewer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectGroupRoleEnum? ToEnum(string value)
        {
            return value switch
            {
                "Annotator" => ProjectGroupRoleEnum.Annotator,
                "Inherit" => ProjectGroupRoleEnum.Inherit,
                "Reviewer" => ProjectGroupRoleEnum.Reviewer,
                _ => null,
            };
        }
    }
}
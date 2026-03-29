//HintName: G.Models.ProjectPublicVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProjectPublicVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        Public,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectPublicVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectPublicVisibility value)
        {
            return value switch
            {
                ProjectPublicVisibility.Private => "private",
                ProjectPublicVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectPublicVisibility? ToEnum(string value)
        {
            return value switch
            {
                "private" => ProjectPublicVisibility.Private,
                "public" => ProjectPublicVisibility.Public,
                _ => null,
            };
        }
    }
}
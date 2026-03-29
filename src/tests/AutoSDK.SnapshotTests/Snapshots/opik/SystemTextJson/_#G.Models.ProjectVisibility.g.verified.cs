//HintName: G.Models.ProjectVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProjectVisibility
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
    public static class ProjectVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectVisibility value)
        {
            return value switch
            {
                ProjectVisibility.Private => "private",
                ProjectVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectVisibility? ToEnum(string value)
        {
            return value switch
            {
                "private" => ProjectVisibility.Private,
                "public" => ProjectVisibility.Public,
                _ => null,
            };
        }
    }
}
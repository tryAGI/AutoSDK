//HintName: G.Models.ProjectWriteVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProjectWriteVisibility
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
    public static class ProjectWriteVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectWriteVisibility value)
        {
            return value switch
            {
                ProjectWriteVisibility.Private => "private",
                ProjectWriteVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectWriteVisibility? ToEnum(string value)
        {
            return value switch
            {
                "private" => ProjectWriteVisibility.Private,
                "public" => ProjectWriteVisibility.Public,
                _ => null,
            };
        }
    }
}
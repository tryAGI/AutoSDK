//HintName: G.Models.ProjectRateLimitListResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProjectRateLimitListResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        List,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectRateLimitListResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectRateLimitListResponseObject value)
        {
            return value switch
            {
                ProjectRateLimitListResponseObject.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectRateLimitListResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "list" => ProjectRateLimitListResponseObject.List,
                _ => null,
            };
        }
    }
}
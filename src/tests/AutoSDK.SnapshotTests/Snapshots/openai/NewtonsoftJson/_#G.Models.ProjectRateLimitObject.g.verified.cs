//HintName: G.Models.ProjectRateLimitObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type, which is always `project.rate_limit`
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ProjectRateLimitObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="project.rate_limit")]
        ProjectRateLimit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectRateLimitObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectRateLimitObject value)
        {
            return value switch
            {
                ProjectRateLimitObject.ProjectRateLimit => "project.rate_limit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectRateLimitObject? ToEnum(string value)
        {
            return value switch
            {
                "project.rate_limit" => ProjectRateLimitObject.ProjectRateLimit,
                _ => null,
            };
        }
    }
}
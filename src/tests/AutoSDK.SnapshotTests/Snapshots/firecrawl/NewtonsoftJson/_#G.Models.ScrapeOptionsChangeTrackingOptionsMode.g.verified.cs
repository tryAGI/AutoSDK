//HintName: G.Models.ScrapeOptionsChangeTrackingOptionsMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ScrapeOptionsChangeTrackingOptionsMode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="git-diff")]
        GitDiff,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="json")]
        Json,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScrapeOptionsChangeTrackingOptionsModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScrapeOptionsChangeTrackingOptionsMode value)
        {
            return value switch
            {
                ScrapeOptionsChangeTrackingOptionsMode.GitDiff => "git-diff",
                ScrapeOptionsChangeTrackingOptionsMode.Json => "json",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScrapeOptionsChangeTrackingOptionsMode? ToEnum(string value)
        {
            return value switch
            {
                "git-diff" => ScrapeOptionsChangeTrackingOptionsMode.GitDiff,
                "json" => ScrapeOptionsChangeTrackingOptionsMode.Json,
                _ => null,
            };
        }
    }
}
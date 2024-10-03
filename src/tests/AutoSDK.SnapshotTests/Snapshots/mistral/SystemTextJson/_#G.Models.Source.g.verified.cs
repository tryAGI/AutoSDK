//HintName: G.Models.Source.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum Source
    {
        /// <summary>
        /// 
        /// </summary>
        Upload,
        /// <summary>
        /// 
        /// </summary>
        Repository,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Source value)
        {
            return value switch
            {
                Source.Upload => "upload",
                Source.Repository => "repository",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Source? ToEnum(string value)
        {
            return value switch
            {
                "upload" => Source.Upload,
                "repository" => Source.Repository,
                _ => null,
            };
        }
    }
}
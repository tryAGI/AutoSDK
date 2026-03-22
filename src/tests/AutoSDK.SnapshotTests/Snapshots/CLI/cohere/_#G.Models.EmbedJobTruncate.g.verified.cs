//HintName: G.Models.EmbedJobTruncate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The truncation option used
    /// </summary>
    public enum EmbedJobTruncate
    {
        /// <summary>
        /// 
        /// </summary>
        End,
        /// <summary>
        /// 
        /// </summary>
        Start,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmbedJobTruncateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbedJobTruncate value)
        {
            return value switch
            {
                EmbedJobTruncate.End => "END",
                EmbedJobTruncate.Start => "START",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbedJobTruncate? ToEnum(string value)
        {
            return value switch
            {
                "END" => EmbedJobTruncate.End,
                "START" => EmbedJobTruncate.Start,
                _ => null,
            };
        }
    }
}
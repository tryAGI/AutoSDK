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
        Start,
        /// <summary>
        /// 
        /// </summary>
        End,
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
                EmbedJobTruncate.Start => "START",
                EmbedJobTruncate.End => "END",
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
                "START" => EmbedJobTruncate.Start,
                "END" => EmbedJobTruncate.End,
                _ => null,
            };
        }
    }
}
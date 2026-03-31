//HintName: G.Models.StreamingMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The mode format of the returned value (defaults to 'auto')
    /// </summary>
    public enum StreamingMode
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Json,
        /// <summary>
        /// 
        /// </summary>
        Parallel,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StreamingModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StreamingMode value)
        {
            return value switch
            {
                StreamingMode.Auto => "auto",
                StreamingMode.Json => "json",
                StreamingMode.Parallel => "parallel",
                StreamingMode.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StreamingMode? ToEnum(string value)
        {
            return value switch
            {
                "auto" => StreamingMode.Auto,
                "json" => StreamingMode.Json,
                "parallel" => StreamingMode.Parallel,
                "text" => StreamingMode.Text,
                _ => null,
            };
        }
    }
}
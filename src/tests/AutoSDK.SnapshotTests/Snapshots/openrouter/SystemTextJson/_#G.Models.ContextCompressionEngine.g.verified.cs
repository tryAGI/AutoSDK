//HintName: G.Models.ContextCompressionEngine.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The compression engine to use. Defaults to "middle-out".
    /// </summary>
    public enum ContextCompressionEngine
    {
        /// <summary>
        /// 
        /// </summary>
        MiddleOut,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContextCompressionEngineExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContextCompressionEngine value)
        {
            return value switch
            {
                ContextCompressionEngine.MiddleOut => "middle-out",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContextCompressionEngine? ToEnum(string value)
        {
            return value switch
            {
                "middle-out" => ContextCompressionEngine.MiddleOut,
                _ => null,
            };
        }
    }
}
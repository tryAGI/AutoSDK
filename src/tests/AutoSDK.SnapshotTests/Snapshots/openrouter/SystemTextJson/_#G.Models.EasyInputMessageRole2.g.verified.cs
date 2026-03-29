//HintName: G.Models.EasyInputMessageRole2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum EasyInputMessageRole2
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EasyInputMessageRole2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EasyInputMessageRole2 value)
        {
            return value switch
            {
                EasyInputMessageRole2.Assistant => "assistant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EasyInputMessageRole2? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => EasyInputMessageRole2.Assistant,
                _ => null,
            };
        }
    }
}
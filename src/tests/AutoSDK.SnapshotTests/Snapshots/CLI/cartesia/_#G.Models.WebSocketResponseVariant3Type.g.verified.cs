//HintName: G.Models.WebSocketResponseVariant3Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebSocketResponseVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        Done,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebSocketResponseVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSocketResponseVariant3Type value)
        {
            return value switch
            {
                WebSocketResponseVariant3Type.Done => "done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSocketResponseVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "done" => WebSocketResponseVariant3Type.Done,
                _ => null,
            };
        }
    }
}
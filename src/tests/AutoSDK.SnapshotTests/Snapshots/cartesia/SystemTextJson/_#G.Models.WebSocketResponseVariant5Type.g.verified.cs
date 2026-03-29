//HintName: G.Models.WebSocketResponseVariant5Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebSocketResponseVariant5Type
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebSocketResponseVariant5TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSocketResponseVariant5Type value)
        {
            return value switch
            {
                WebSocketResponseVariant5Type.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSocketResponseVariant5Type? ToEnum(string value)
        {
            return value switch
            {
                "error" => WebSocketResponseVariant5Type.Error,
                _ => null,
            };
        }
    }
}
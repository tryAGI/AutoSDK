//HintName: G.Models.WebSocketResponseVariant4Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebSocketResponseVariant4Type
    {
        /// <summary>
        /// 
        /// </summary>
        Timestamps,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebSocketResponseVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSocketResponseVariant4Type value)
        {
            return value switch
            {
                WebSocketResponseVariant4Type.Timestamps => "timestamps",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSocketResponseVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "timestamps" => WebSocketResponseVariant4Type.Timestamps,
                _ => null,
            };
        }
    }
}
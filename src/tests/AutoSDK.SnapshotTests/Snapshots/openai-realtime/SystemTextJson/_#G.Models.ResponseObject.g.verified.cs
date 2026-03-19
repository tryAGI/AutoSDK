//HintName: G.Models.ResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type.
    /// </summary>
    public enum ResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        RealtimeResponse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseObject value)
        {
            return value switch
            {
                ResponseObject.RealtimeResponse => "realtime.response",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "realtime.response" => ResponseObject.RealtimeResponse,
                _ => null,
            };
        }
    }
}
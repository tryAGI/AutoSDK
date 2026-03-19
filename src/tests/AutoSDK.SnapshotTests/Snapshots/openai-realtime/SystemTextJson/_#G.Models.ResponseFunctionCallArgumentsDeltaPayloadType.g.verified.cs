//HintName: G.Models.ResponseFunctionCallArgumentsDeltaPayloadType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type.
    /// </summary>
    public enum ResponseFunctionCallArgumentsDeltaPayloadType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseFunctionCallArgumentsDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseFunctionCallArgumentsDeltaPayloadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseFunctionCallArgumentsDeltaPayloadType value)
        {
            return value switch
            {
                ResponseFunctionCallArgumentsDeltaPayloadType.ResponseFunctionCallArgumentsDelta => "response.function_call_arguments.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseFunctionCallArgumentsDeltaPayloadType? ToEnum(string value)
        {
            return value switch
            {
                "response.function_call_arguments.delta" => ResponseFunctionCallArgumentsDeltaPayloadType.ResponseFunctionCallArgumentsDelta,
                _ => null,
            };
        }
    }
}
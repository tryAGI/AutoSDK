//HintName: G.Models.ResponseFunctionCallArgumentsDeltaEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the event. Always `response.function_call_arguments.delta`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseFunctionCallArgumentsDeltaEventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.function_call_arguments.delta")]
        ResponseFunctionCallArgumentsDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseFunctionCallArgumentsDeltaEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseFunctionCallArgumentsDeltaEventType value)
        {
            return value switch
            {
                ResponseFunctionCallArgumentsDeltaEventType.ResponseFunctionCallArgumentsDelta => "response.function_call_arguments.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseFunctionCallArgumentsDeltaEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.function_call_arguments.delta" => ResponseFunctionCallArgumentsDeltaEventType.ResponseFunctionCallArgumentsDelta,
                _ => null,
            };
        }
    }
}
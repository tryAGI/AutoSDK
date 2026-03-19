//HintName: G.Models.ResponseFunctionCallArgumentsDonePayloadType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type.
    /// </summary>
    public enum ResponseFunctionCallArgumentsDonePayloadType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseFunctionCallArgumentsDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseFunctionCallArgumentsDonePayloadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseFunctionCallArgumentsDonePayloadType value)
        {
            return value switch
            {
                ResponseFunctionCallArgumentsDonePayloadType.ResponseFunctionCallArgumentsDone => "response.function_call_arguments.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseFunctionCallArgumentsDonePayloadType? ToEnum(string value)
        {
            return value switch
            {
                "response.function_call_arguments.done" => ResponseFunctionCallArgumentsDonePayloadType.ResponseFunctionCallArgumentsDone,
                _ => null,
            };
        }
    }
}
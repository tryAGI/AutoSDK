//HintName: G.Models.ResponseFunctionCallArgumentsDoneEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseFunctionCallArgumentsDoneEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseFunctionCallArgumentsDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseFunctionCallArgumentsDoneEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseFunctionCallArgumentsDoneEventType value)
        {
            return value switch
            {
                ResponseFunctionCallArgumentsDoneEventType.ResponseFunctionCallArgumentsDone => "response.function_call_arguments.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseFunctionCallArgumentsDoneEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.function_call_arguments.done" => ResponseFunctionCallArgumentsDoneEventType.ResponseFunctionCallArgumentsDone,
                _ => null,
            };
        }
    }
}
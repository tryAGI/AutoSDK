//HintName: G.Models.ResponseTextDoneEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the event. Always `response.output_text.done`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseTextDoneEventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.output_text.done")]
        ResponseOutputTextDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseTextDoneEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseTextDoneEventType value)
        {
            return value switch
            {
                ResponseTextDoneEventType.ResponseOutputTextDone => "response.output_text.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseTextDoneEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.output_text.done" => ResponseTextDoneEventType.ResponseOutputTextDone,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.ResponseIncompleteEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the event. Always `response.incomplete`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseIncompleteEventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.incomplete")]
        ResponseIncomplete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseIncompleteEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseIncompleteEventType value)
        {
            return value switch
            {
                ResponseIncompleteEventType.ResponseIncomplete => "response.incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseIncompleteEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.incomplete" => ResponseIncompleteEventType.ResponseIncomplete,
                _ => null,
            };
        }
    }
}
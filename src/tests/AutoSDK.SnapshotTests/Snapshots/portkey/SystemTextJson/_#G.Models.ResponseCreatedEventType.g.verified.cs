//HintName: G.Models.ResponseCreatedEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the event. Always `response.created`.
    /// </summary>
    public enum ResponseCreatedEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseCreated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseCreatedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseCreatedEventType value)
        {
            return value switch
            {
                ResponseCreatedEventType.ResponseCreated => "response.created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseCreatedEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.created" => ResponseCreatedEventType.ResponseCreated,
                _ => null,
            };
        }
    }
}
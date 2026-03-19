//HintName: G.Models.ResponseCreatedPayloadType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type.
    /// </summary>
    public enum ResponseCreatedPayloadType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseCreated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseCreatedPayloadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseCreatedPayloadType value)
        {
            return value switch
            {
                ResponseCreatedPayloadType.ResponseCreated => "response.created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseCreatedPayloadType? ToEnum(string value)
        {
            return value switch
            {
                "response.created" => ResponseCreatedPayloadType.ResponseCreated,
                _ => null,
            };
        }
    }
}
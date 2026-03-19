//HintName: G.Models.ResponseCreatePayloadType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseCreatePayloadType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.create")]
        ResponseCreate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseCreatePayloadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseCreatePayloadType value)
        {
            return value switch
            {
                ResponseCreatePayloadType.ResponseCreate => "response.create",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseCreatePayloadType? ToEnum(string value)
        {
            return value switch
            {
                "response.create" => ResponseCreatePayloadType.ResponseCreate,
                _ => null,
            };
        }
    }
}
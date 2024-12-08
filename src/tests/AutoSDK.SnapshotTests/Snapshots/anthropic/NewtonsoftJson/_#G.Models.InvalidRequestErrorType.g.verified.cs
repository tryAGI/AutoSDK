//HintName: G.Models.InvalidRequestErrorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: invalid_request_error
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum InvalidRequestErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="invalid_request_error")]
        InvalidRequestError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InvalidRequestErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InvalidRequestErrorType value)
        {
            return value switch
            {
                InvalidRequestErrorType.InvalidRequestError => "invalid_request_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InvalidRequestErrorType? ToEnum(string value)
        {
            return value switch
            {
                "invalid_request_error" => InvalidRequestErrorType.InvalidRequestError,
                _ => null,
            };
        }
    }
}
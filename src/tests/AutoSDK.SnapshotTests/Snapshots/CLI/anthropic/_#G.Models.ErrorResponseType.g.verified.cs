//HintName: G.Models.ErrorResponseType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: error
    /// </summary>
    public enum ErrorResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ErrorResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ErrorResponseType value)
        {
            return value switch
            {
                ErrorResponseType.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ErrorResponseType? ToEnum(string value)
        {
            return value switch
            {
                "error" => ErrorResponseType.Error,
                _ => null,
            };
        }
    }
}
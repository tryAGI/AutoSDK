//HintName: G.Models.ListPhoneNumbersResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListPhoneNumbersResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListPhoneNumbersResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListPhoneNumbersResponseStatus value)
        {
            return value switch
            {
                ListPhoneNumbersResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListPhoneNumbersResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => ListPhoneNumbersResponseStatus.Error,
                _ => null,
            };
        }
    }
}
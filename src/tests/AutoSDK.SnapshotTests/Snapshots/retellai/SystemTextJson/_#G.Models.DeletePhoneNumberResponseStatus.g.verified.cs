//HintName: G.Models.DeletePhoneNumberResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeletePhoneNumberResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeletePhoneNumberResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeletePhoneNumberResponseStatus value)
        {
            return value switch
            {
                DeletePhoneNumberResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeletePhoneNumberResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => DeletePhoneNumberResponseStatus.Error,
                _ => null,
            };
        }
    }
}
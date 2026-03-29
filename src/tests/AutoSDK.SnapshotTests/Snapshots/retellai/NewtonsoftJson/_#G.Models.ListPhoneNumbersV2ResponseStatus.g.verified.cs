//HintName: G.Models.ListPhoneNumbersV2ResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListPhoneNumbersV2ResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListPhoneNumbersV2ResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListPhoneNumbersV2ResponseStatus value)
        {
            return value switch
            {
                ListPhoneNumbersV2ResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListPhoneNumbersV2ResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => ListPhoneNumbersV2ResponseStatus.Error,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.LocaleResponseSupportsItems.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Dubbing Type supported by locale
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum LocaleResponseSupportsItems
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="AUTOMATED")]
        Automated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="QA")]
        Qa,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LocaleResponseSupportsItemsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LocaleResponseSupportsItems value)
        {
            return value switch
            {
                LocaleResponseSupportsItems.Automated => "AUTOMATED",
                LocaleResponseSupportsItems.Qa => "QA",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LocaleResponseSupportsItems? ToEnum(string value)
        {
            return value switch
            {
                "AUTOMATED" => LocaleResponseSupportsItems.Automated,
                "QA" => LocaleResponseSupportsItems.Qa,
                _ => null,
            };
        }
    }
}
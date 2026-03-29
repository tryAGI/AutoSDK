//HintName: G.Models.SmsContentPredefinedType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SmsContentPredefinedType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="predefined")]
        Predefined,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SmsContentPredefinedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SmsContentPredefinedType value)
        {
            return value switch
            {
                SmsContentPredefinedType.Predefined => "predefined",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SmsContentPredefinedType? ToEnum(string value)
        {
            return value switch
            {
                "predefined" => SmsContentPredefinedType.Predefined,
                _ => null,
            };
        }
    }
}
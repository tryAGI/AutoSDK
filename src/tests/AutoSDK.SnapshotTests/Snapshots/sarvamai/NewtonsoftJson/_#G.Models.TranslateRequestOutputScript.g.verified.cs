//HintName: G.Models.TranslateRequestOutputScript.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Controls transliteration style applied to the output text
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TranslateRequestOutputScript
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fully-native")]
        FullyNative,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="roman")]
        Roman,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="spoken-form-in-native")]
        SpokenFormInNative,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranslateRequestOutputScriptExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranslateRequestOutputScript value)
        {
            return value switch
            {
                TranslateRequestOutputScript.FullyNative => "fully-native",
                TranslateRequestOutputScript.Roman => "roman",
                TranslateRequestOutputScript.SpokenFormInNative => "spoken-form-in-native",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranslateRequestOutputScript? ToEnum(string value)
        {
            return value switch
            {
                "fully-native" => TranslateRequestOutputScript.FullyNative,
                "roman" => TranslateRequestOutputScript.Roman,
                "spoken-form-in-native" => TranslateRequestOutputScript.SpokenFormInNative,
                _ => null,
            };
        }
    }
}
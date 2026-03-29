//HintName: G.Models.TranslateRequestMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Tone or style of the translation<br/>
    /// Default Value: formal
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TranslateRequestMode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="classic-colloquial")]
        ClassicColloquial,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="code-mixed")]
        CodeMixed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="formal")]
        Formal,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="modern-colloquial")]
        ModernColloquial,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranslateRequestModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranslateRequestMode value)
        {
            return value switch
            {
                TranslateRequestMode.ClassicColloquial => "classic-colloquial",
                TranslateRequestMode.CodeMixed => "code-mixed",
                TranslateRequestMode.Formal => "formal",
                TranslateRequestMode.ModernColloquial => "modern-colloquial",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranslateRequestMode? ToEnum(string value)
        {
            return value switch
            {
                "classic-colloquial" => TranslateRequestMode.ClassicColloquial,
                "code-mixed" => TranslateRequestMode.CodeMixed,
                "formal" => TranslateRequestMode.Formal,
                "modern-colloquial" => TranslateRequestMode.ModernColloquial,
                _ => null,
            };
        }
    }
}
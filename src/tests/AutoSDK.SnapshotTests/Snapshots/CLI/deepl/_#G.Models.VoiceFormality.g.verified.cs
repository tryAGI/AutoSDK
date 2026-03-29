//HintName: G.Models.VoiceFormality.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sets whether the translated text should lean towards formal or informal language.<br/>
    /// Possible options are:<br/>
    ///   * `default` - use the default formality for the target language<br/>
    ///   * `formal`/`more` - for a more formal language<br/>
    ///   * `informal`/`less` - for a more informal language<br/>
    /// Default Value: default<br/>
    /// Example: formal
    /// </summary>
    public enum VoiceFormality
    {
        /// <summary>
        /// 
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        Formal,
        /// <summary>
        /// 
        /// </summary>
        Informal,
        /// <summary>
        /// 
        /// </summary>
        Less,
        /// <summary>
        /// 
        /// </summary>
        More,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoiceFormalityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceFormality value)
        {
            return value switch
            {
                VoiceFormality.Default => "default",
                VoiceFormality.Formal => "formal",
                VoiceFormality.Informal => "informal",
                VoiceFormality.Less => "less",
                VoiceFormality.More => "more",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceFormality? ToEnum(string value)
        {
            return value switch
            {
                "default" => VoiceFormality.Default,
                "formal" => VoiceFormality.Formal,
                "informal" => VoiceFormality.Informal,
                "less" => VoiceFormality.Less,
                "more" => VoiceFormality.More,
                _ => null,
            };
        }
    }
}
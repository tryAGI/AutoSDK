//HintName: G.Models.RimeAIVoiceLanguage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Language for speech synthesis. Uses ISO 639 codes. Supported: en, es, de, fr, ar, hi, ja, he, pt, ta, si.<br/>
    /// Example: en
    /// </summary>
    public enum RimeAIVoiceLanguage
    {
        /// <summary>
        /// en, es, de, fr, ar, hi, ja, he, pt, ta, si.
        /// </summary>
        Ar,
        /// <summary>
        /// en, es, de, fr, ar, hi, ja, he, pt, ta, si.
        /// </summary>
        De,
        /// <summary>
        /// en, es, de, fr, ar, hi, ja, he, pt, ta, si.
        /// </summary>
        En,
        /// <summary>
        /// en, es, de, fr, ar, hi, ja, he, pt, ta, si.
        /// </summary>
        Es,
        /// <summary>
        /// en, es, de, fr, ar, hi, ja, he, pt, ta, si.
        /// </summary>
        Fr,
        /// <summary>
        /// en, es, de, fr, ar, hi, ja, he, pt, ta, si.
        /// </summary>
        He,
        /// <summary>
        /// en, es, de, fr, ar, hi, ja, he, pt, ta, si.
        /// </summary>
        Hi,
        /// <summary>
        /// en, es, de, fr, ar, hi, ja, he, pt, ta, si.
        /// </summary>
        Ja,
        /// <summary>
        /// en, es, de, fr, ar, hi, ja, he, pt, ta, si.
        /// </summary>
        Pt,
        /// <summary>
        /// en, es, de, fr, ar, hi, ja, he, pt, ta, si.
        /// </summary>
        Si,
        /// <summary>
        /// en, es, de, fr, ar, hi, ja, he, pt, ta, si.
        /// </summary>
        Ta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RimeAIVoiceLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RimeAIVoiceLanguage value)
        {
            return value switch
            {
                RimeAIVoiceLanguage.Ar => "ar",
                RimeAIVoiceLanguage.De => "de",
                RimeAIVoiceLanguage.En => "en",
                RimeAIVoiceLanguage.Es => "es",
                RimeAIVoiceLanguage.Fr => "fr",
                RimeAIVoiceLanguage.He => "he",
                RimeAIVoiceLanguage.Hi => "hi",
                RimeAIVoiceLanguage.Ja => "ja",
                RimeAIVoiceLanguage.Pt => "pt",
                RimeAIVoiceLanguage.Si => "si",
                RimeAIVoiceLanguage.Ta => "ta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RimeAIVoiceLanguage? ToEnum(string value)
        {
            return value switch
            {
                "ar" => RimeAIVoiceLanguage.Ar,
                "de" => RimeAIVoiceLanguage.De,
                "en" => RimeAIVoiceLanguage.En,
                "es" => RimeAIVoiceLanguage.Es,
                "fr" => RimeAIVoiceLanguage.Fr,
                "he" => RimeAIVoiceLanguage.He,
                "hi" => RimeAIVoiceLanguage.Hi,
                "ja" => RimeAIVoiceLanguage.Ja,
                "pt" => RimeAIVoiceLanguage.Pt,
                "si" => RimeAIVoiceLanguage.Si,
                "ta" => RimeAIVoiceLanguage.Ta,
                _ => null,
            };
        }
    }
}
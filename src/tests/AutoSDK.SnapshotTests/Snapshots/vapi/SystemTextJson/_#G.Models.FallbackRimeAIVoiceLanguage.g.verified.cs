//HintName: G.Models.FallbackRimeAIVoiceLanguage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Language for speech synthesis. Uses ISO 639 codes. Supported: en, es, de, fr, ar, hi, ja, he, pt, ta, si.<br/>
    /// Example: en
    /// </summary>
    public enum FallbackRimeAIVoiceLanguage
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
    public static class FallbackRimeAIVoiceLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackRimeAIVoiceLanguage value)
        {
            return value switch
            {
                FallbackRimeAIVoiceLanguage.Ar => "ar",
                FallbackRimeAIVoiceLanguage.De => "de",
                FallbackRimeAIVoiceLanguage.En => "en",
                FallbackRimeAIVoiceLanguage.Es => "es",
                FallbackRimeAIVoiceLanguage.Fr => "fr",
                FallbackRimeAIVoiceLanguage.He => "he",
                FallbackRimeAIVoiceLanguage.Hi => "hi",
                FallbackRimeAIVoiceLanguage.Ja => "ja",
                FallbackRimeAIVoiceLanguage.Pt => "pt",
                FallbackRimeAIVoiceLanguage.Si => "si",
                FallbackRimeAIVoiceLanguage.Ta => "ta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackRimeAIVoiceLanguage? ToEnum(string value)
        {
            return value switch
            {
                "ar" => FallbackRimeAIVoiceLanguage.Ar,
                "de" => FallbackRimeAIVoiceLanguage.De,
                "en" => FallbackRimeAIVoiceLanguage.En,
                "es" => FallbackRimeAIVoiceLanguage.Es,
                "fr" => FallbackRimeAIVoiceLanguage.Fr,
                "he" => FallbackRimeAIVoiceLanguage.He,
                "hi" => FallbackRimeAIVoiceLanguage.Hi,
                "ja" => FallbackRimeAIVoiceLanguage.Ja,
                "pt" => FallbackRimeAIVoiceLanguage.Pt,
                "si" => FallbackRimeAIVoiceLanguage.Si,
                "ta" => FallbackRimeAIVoiceLanguage.Ta,
                _ => null,
            };
        }
    }
}
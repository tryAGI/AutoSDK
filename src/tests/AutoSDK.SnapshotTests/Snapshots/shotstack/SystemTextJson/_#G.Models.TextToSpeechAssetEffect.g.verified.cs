//HintName: G.Models.TextToSpeechAssetEffect.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The effect to apply to the audio asset &lt;ul&gt;<br/>
    ///   &lt;li&gt;`fadeIn` - fade volume in only&lt;/li&gt;<br/>
    ///   &lt;li&gt;`fadeOut` - fade volume out only&lt;/li&gt;<br/>
    ///   &lt;li&gt;`fadeInFadeOut` - fade volume in and out&lt;/li&gt;<br/>
    /// &lt;/ul&gt;
    /// </summary>
    public enum TextToSpeechAssetEffect
    {
        /// <summary>
        /// 
        /// </summary>
        FadeIn,
        /// <summary>
        /// 
        /// </summary>
        FadeInFadeOut,
        /// <summary>
        /// 
        /// </summary>
        FadeOut,
        /// <summary>
        /// 
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextToSpeechAssetEffectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextToSpeechAssetEffect value)
        {
            return value switch
            {
                TextToSpeechAssetEffect.FadeIn => "fadeIn",
                TextToSpeechAssetEffect.FadeInFadeOut => "fadeInFadeOut",
                TextToSpeechAssetEffect.FadeOut => "fadeOut",
                TextToSpeechAssetEffect.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextToSpeechAssetEffect? ToEnum(string value)
        {
            return value switch
            {
                "fadeIn" => TextToSpeechAssetEffect.FadeIn,
                "fadeInFadeOut" => TextToSpeechAssetEffect.FadeInFadeOut,
                "fadeOut" => TextToSpeechAssetEffect.FadeOut,
                "none" => TextToSpeechAssetEffect.None,
                _ => null,
            };
        }
    }
}
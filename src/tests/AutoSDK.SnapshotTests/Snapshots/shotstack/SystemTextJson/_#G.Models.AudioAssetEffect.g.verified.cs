//HintName: G.Models.AudioAssetEffect.g.cs

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
    public enum AudioAssetEffect
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
    public static class AudioAssetEffectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioAssetEffect value)
        {
            return value switch
            {
                AudioAssetEffect.FadeIn => "fadeIn",
                AudioAssetEffect.FadeInFadeOut => "fadeInFadeOut",
                AudioAssetEffect.FadeOut => "fadeOut",
                AudioAssetEffect.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioAssetEffect? ToEnum(string value)
        {
            return value switch
            {
                "fadeIn" => AudioAssetEffect.FadeIn,
                "fadeInFadeOut" => AudioAssetEffect.FadeInFadeOut,
                "fadeOut" => AudioAssetEffect.FadeOut,
                "none" => AudioAssetEffect.None,
                _ => null,
            };
        }
    }
}
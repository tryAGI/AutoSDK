//HintName: G.Models.SoundtrackEffect.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The effect to apply to the audio file &lt;ul&gt;<br/>
    ///   &lt;li&gt;`fadeIn` - fade volume in only&lt;/li&gt;<br/>
    ///   &lt;li&gt;`fadeOut` - fade volume out only&lt;/li&gt;<br/>
    ///   &lt;li&gt;`fadeInFadeOut` - fade volume in and out&lt;/li&gt;<br/>
    /// &lt;/ul&gt;
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SoundtrackEffect
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fadeIn")]
        FadeIn,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fadeInFadeOut")]
        FadeInFadeOut,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fadeOut")]
        FadeOut,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SoundtrackEffectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SoundtrackEffect value)
        {
            return value switch
            {
                SoundtrackEffect.FadeIn => "fadeIn",
                SoundtrackEffect.FadeInFadeOut => "fadeInFadeOut",
                SoundtrackEffect.FadeOut => "fadeOut",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SoundtrackEffect? ToEnum(string value)
        {
            return value switch
            {
                "fadeIn" => SoundtrackEffect.FadeIn,
                "fadeInFadeOut" => SoundtrackEffect.FadeInFadeOut,
                "fadeOut" => SoundtrackEffect.FadeOut,
                _ => null,
            };
        }
    }
}
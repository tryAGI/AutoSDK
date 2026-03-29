//HintName: G.Models.VideoAssetVolumeEffect.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Preset volume effects to apply to the video asset &lt;ul&gt;<br/>
    ///   &lt;li&gt;`fadeIn` - fade volume in only&lt;/li&gt;<br/>
    ///   &lt;li&gt;`fadeOut` - fade volume out only&lt;/li&gt;<br/>
    ///   &lt;li&gt;`fadeInFadeOut` - fade volume in and out&lt;/li&gt;<br/>
    /// &lt;/ul&gt;
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum VideoAssetVolumeEffect
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
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="none")]
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoAssetVolumeEffectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoAssetVolumeEffect value)
        {
            return value switch
            {
                VideoAssetVolumeEffect.FadeIn => "fadeIn",
                VideoAssetVolumeEffect.FadeInFadeOut => "fadeInFadeOut",
                VideoAssetVolumeEffect.FadeOut => "fadeOut",
                VideoAssetVolumeEffect.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoAssetVolumeEffect? ToEnum(string value)
        {
            return value switch
            {
                "fadeIn" => VideoAssetVolumeEffect.FadeIn,
                "fadeInFadeOut" => VideoAssetVolumeEffect.FadeInFadeOut,
                "fadeOut" => VideoAssetVolumeEffect.FadeOut,
                "none" => VideoAssetVolumeEffect.None,
                _ => null,
            };
        }
    }
}
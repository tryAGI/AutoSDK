//HintName: G.Models.RichTextAnimationPreset.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The animation preset to apply. Available presets: &lt;ul&gt;<br/>
    ///   &lt;li&gt;`fadeIn` - fadeIn in animation&lt;/li&gt;<br/>
    ///   &lt;li&gt;`slideIn` - slide in from a direction&lt;/li&gt;<br/>
    ///   &lt;li&gt;`typewriter` - typewriter effect&lt;/li&gt;<br/>
    ///   &lt;li&gt;`ascend` - ascend from a direction&lt;/li&gt;<br/>
    ///   &lt;li&gt;`shift` - shift in from a direction&lt;/li&gt;<br/>
    ///   &lt;li&gt;`movingLetters` - letters move in from a direction&lt;/li&gt;<br/>
    /// &lt;/ul&gt;<br/>
    /// Example: shift
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RichTextAnimationPreset
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ascend")]
        Ascend,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fadeIn")]
        FadeIn,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="movingLetters")]
        MovingLetters,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="shift")]
        Shift,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="slideIn")]
        SlideIn,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="typewriter")]
        Typewriter,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RichTextAnimationPresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RichTextAnimationPreset value)
        {
            return value switch
            {
                RichTextAnimationPreset.Ascend => "ascend",
                RichTextAnimationPreset.FadeIn => "fadeIn",
                RichTextAnimationPreset.MovingLetters => "movingLetters",
                RichTextAnimationPreset.Shift => "shift",
                RichTextAnimationPreset.SlideIn => "slideIn",
                RichTextAnimationPreset.Typewriter => "typewriter",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RichTextAnimationPreset? ToEnum(string value)
        {
            return value switch
            {
                "ascend" => RichTextAnimationPreset.Ascend,
                "fadeIn" => RichTextAnimationPreset.FadeIn,
                "movingLetters" => RichTextAnimationPreset.MovingLetters,
                "shift" => RichTextAnimationPreset.Shift,
                "slideIn" => RichTextAnimationPreset.SlideIn,
                "typewriter" => RichTextAnimationPreset.Typewriter,
                _ => null,
            };
        }
    }
}
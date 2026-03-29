//HintName: G.Models.RichCaptionAnimationStyle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The animation style to apply to words: &lt;ul&gt;<br/>
    ///   &lt;li&gt;`karaoke` - Word-by-word color fill as spoken (shows all words, highlights active)&lt;/li&gt;<br/>
    ///   &lt;li&gt;`highlight` - Word changes to active color when spoken (shows all words)&lt;/li&gt;<br/>
    ///   &lt;li&gt;`pop` - Each word scales up when active&lt;/li&gt;<br/>
    ///   &lt;li&gt;`fade` - Gradual opacity transition per word&lt;/li&gt;<br/>
    ///   &lt;li&gt;`slide` - Words slide in from a direction&lt;/li&gt;<br/>
    ///   &lt;li&gt;`bounce` - Spring animation on word appearance&lt;/li&gt;<br/>
    ///   &lt;li&gt;`typewriter` - Words appear one by one and stay visible&lt;/li&gt;<br/>
    ///   &lt;li&gt;`none` - No animation, all words visible immediately&lt;/li&gt;<br/>
    /// &lt;/ul&gt;<br/>
    /// Default Value: highlight<br/>
    /// Example: highlight
    /// </summary>
    public enum RichCaptionAnimationStyle
    {
        /// <summary>
        /// 
        /// </summary>
        Bounce,
        /// <summary>
        /// 
        /// </summary>
        Fade,
        /// <summary>
        /// 
        /// </summary>
        Highlight,
        /// <summary>
        /// 
        /// </summary>
        Karaoke,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Pop,
        /// <summary>
        /// 
        /// </summary>
        Slide,
        /// <summary>
        /// 
        /// </summary>
        Typewriter,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RichCaptionAnimationStyleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RichCaptionAnimationStyle value)
        {
            return value switch
            {
                RichCaptionAnimationStyle.Bounce => "bounce",
                RichCaptionAnimationStyle.Fade => "fade",
                RichCaptionAnimationStyle.Highlight => "highlight",
                RichCaptionAnimationStyle.Karaoke => "karaoke",
                RichCaptionAnimationStyle.None => "none",
                RichCaptionAnimationStyle.Pop => "pop",
                RichCaptionAnimationStyle.Slide => "slide",
                RichCaptionAnimationStyle.Typewriter => "typewriter",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RichCaptionAnimationStyle? ToEnum(string value)
        {
            return value switch
            {
                "bounce" => RichCaptionAnimationStyle.Bounce,
                "fade" => RichCaptionAnimationStyle.Fade,
                "highlight" => RichCaptionAnimationStyle.Highlight,
                "karaoke" => RichCaptionAnimationStyle.Karaoke,
                "none" => RichCaptionAnimationStyle.None,
                "pop" => RichCaptionAnimationStyle.Pop,
                "slide" => RichCaptionAnimationStyle.Slide,
                "typewriter" => RichCaptionAnimationStyle.Typewriter,
                _ => null,
            };
        }
    }
}
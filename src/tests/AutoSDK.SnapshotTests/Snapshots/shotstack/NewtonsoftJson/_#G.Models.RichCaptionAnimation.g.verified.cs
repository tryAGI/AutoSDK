//HintName: G.Models.RichCaptionAnimation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Word-level animation properties for caption effects.
    /// </summary>
    public sealed partial class RichCaptionAnimation
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
        /// <default>global::G.RichCaptionAnimationStyle.Highlight</default>
        /// <example>highlight</example>
        [global::Newtonsoft.Json.JsonProperty("style", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.RichCaptionAnimationStyleJsonConverter))]
        public global::G.RichCaptionAnimationStyle Style { get; set; } = default!;

        /// <summary>
        /// Direction for directional animations (slide). Only applicable when style is `slide`.<br/>
        /// Default Value: up<br/>
        /// Example: up
        /// </summary>
        /// <example>up</example>
        [global::Newtonsoft.Json.JsonProperty("direction")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.RichCaptionAnimationDirectionJsonConverter))]
        public global::G.RichCaptionAnimationDirection? Direction { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RichCaptionAnimation" /> class.
        /// </summary>
        /// <param name="style">
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
        /// </param>
        /// <param name="direction">
        /// Direction for directional animations (slide). Only applicable when style is `slide`.<br/>
        /// Default Value: up<br/>
        /// Example: up
        /// </param>
        public RichCaptionAnimation(
            global::G.RichCaptionAnimationStyle style,
            global::G.RichCaptionAnimationDirection? direction)
        {
            this.Style = style;
            this.Direction = direction;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RichCaptionAnimation" /> class.
        /// </summary>
        public RichCaptionAnimation()
        {
        }
    }
}
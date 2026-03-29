//HintName: G.Models.RichTextAnimation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Animation properties for text entrance effects.
    /// </summary>
    public sealed partial class RichTextAnimation
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
        /// <example>shift</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("preset")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RichTextAnimationPresetJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RichTextAnimationPreset Preset { get; set; }

        /// <summary>
        /// Override animation duration in seconds. Must be between 0.1 and 30 seconds.<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// Animation style - animate by character or by word. Only applicable for typewriter and shift animations.<br/>
        /// Example: character
        /// </summary>
        /// <example>character</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("style")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RichTextAnimationStyleJsonConverter))]
        public global::G.RichTextAnimationStyle? Style { get; set; }

        /// <summary>
        /// Direction for directional animations. Required for slideIn, ascend, shift, and movingLetters presets. &lt;ul&gt;<br/>
        ///   &lt;li&gt;`ascend` - supports: up, down&lt;/li&gt;<br/>
        ///   &lt;li&gt;`shift` - supports: left, right, up, down&lt;/li&gt;<br/>
        ///   &lt;li&gt;`slideIn` - supports: left, right, up, down&lt;/li&gt;<br/>
        ///   &lt;li&gt;`movingLetters` - supports: left, right, up, down&lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// Example: up
        /// </summary>
        /// <example>up</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("direction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RichTextAnimationDirectionJsonConverter))]
        public global::G.RichTextAnimationDirection? Direction { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RichTextAnimation" /> class.
        /// </summary>
        /// <param name="preset">
        /// The animation preset to apply. Available presets: &lt;ul&gt;<br/>
        ///   &lt;li&gt;`fadeIn` - fadeIn in animation&lt;/li&gt;<br/>
        ///   &lt;li&gt;`slideIn` - slide in from a direction&lt;/li&gt;<br/>
        ///   &lt;li&gt;`typewriter` - typewriter effect&lt;/li&gt;<br/>
        ///   &lt;li&gt;`ascend` - ascend from a direction&lt;/li&gt;<br/>
        ///   &lt;li&gt;`shift` - shift in from a direction&lt;/li&gt;<br/>
        ///   &lt;li&gt;`movingLetters` - letters move in from a direction&lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// Example: shift
        /// </param>
        /// <param name="duration">
        /// Override animation duration in seconds. Must be between 0.1 and 30 seconds.<br/>
        /// Example: 2
        /// </param>
        /// <param name="style">
        /// Animation style - animate by character or by word. Only applicable for typewriter and shift animations.<br/>
        /// Example: character
        /// </param>
        /// <param name="direction">
        /// Direction for directional animations. Required for slideIn, ascend, shift, and movingLetters presets. &lt;ul&gt;<br/>
        ///   &lt;li&gt;`ascend` - supports: up, down&lt;/li&gt;<br/>
        ///   &lt;li&gt;`shift` - supports: left, right, up, down&lt;/li&gt;<br/>
        ///   &lt;li&gt;`slideIn` - supports: left, right, up, down&lt;/li&gt;<br/>
        ///   &lt;li&gt;`movingLetters` - supports: left, right, up, down&lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// Example: up
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RichTextAnimation(
            global::G.RichTextAnimationPreset preset,
            double? duration,
            global::G.RichTextAnimationStyle? style,
            global::G.RichTextAnimationDirection? direction)
        {
            this.Preset = preset;
            this.Duration = duration;
            this.Style = style;
            this.Direction = direction;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RichTextAnimation" /> class.
        /// </summary>
        public RichTextAnimation()
        {
        }
    }
}
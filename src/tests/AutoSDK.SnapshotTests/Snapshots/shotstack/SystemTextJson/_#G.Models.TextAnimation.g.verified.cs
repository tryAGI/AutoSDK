//HintName: G.Models.TextAnimation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Animation properties for text entrance effects.
    /// </summary>
    public sealed partial class TextAnimation
    {
        /// <summary>
        /// The animation preset to apply. &lt;ul&gt;<br/>
        ///   &lt;li&gt;`typewriter` - typewriter effect where characters appear one at a time&lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// Example: typewriter
        /// </summary>
        /// <example>typewriter</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("preset")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TextAnimationPresetJsonConverter))]
        public global::G.TextAnimationPreset Preset { get; set; }

        /// <summary>
        /// The duration of the animation in seconds.<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextAnimation" /> class.
        /// </summary>
        /// <param name="preset">
        /// The animation preset to apply. &lt;ul&gt;<br/>
        ///   &lt;li&gt;`typewriter` - typewriter effect where characters appear one at a time&lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// Example: typewriter
        /// </param>
        /// <param name="duration">
        /// The duration of the animation in seconds.<br/>
        /// Example: 2
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextAnimation(
            global::G.TextAnimationPreset preset,
            double? duration)
        {
            this.Preset = preset;
            this.Duration = duration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextAnimation" /> class.
        /// </summary>
        public TextAnimation()
        {
        }
    }
}
//HintName: G.Models.DolbyEnhancementOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Options for the Dolby.io audio enhancement provider.
    /// </summary>
    public sealed partial class DolbyEnhancementOptions
    {
        /// <summary>
        /// The preset to use for the audio enhancement. The following presets are available: &lt;ul&gt;<br/>
        ///   &lt;li&gt;`conference` - Conference&lt;/li&gt;<br/>
        ///   &lt;li&gt;`interview` - Interview&lt;/li&gt;<br/>
        ///   &lt;li&gt;`lecture` - Lecture&lt;/li&gt;<br/>
        ///   &lt;li&gt;`meeting` - Meeting&lt;/li&gt;<br/>
        ///   &lt;li&gt;`mobile_phone` - Mobile Phone&lt;/li&gt;<br/>
        ///   &lt;li&gt;`music` - Music&lt;/li&gt;<br/>
        ///   &lt;li&gt;`podcast` - Podcast&lt;/li&gt;<br/>
        ///   &lt;li&gt;`studio` - Studio&lt;/li&gt;<br/>
        ///   &lt;li&gt;`voice_over` - Voice Over&lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// Example: studio
        /// </summary>
        /// <example>studio</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("preset")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DolbyEnhancementOptionsPresetJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DolbyEnhancementOptionsPreset Preset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DolbyEnhancementOptions" /> class.
        /// </summary>
        /// <param name="preset">
        /// The preset to use for the audio enhancement. The following presets are available: &lt;ul&gt;<br/>
        ///   &lt;li&gt;`conference` - Conference&lt;/li&gt;<br/>
        ///   &lt;li&gt;`interview` - Interview&lt;/li&gt;<br/>
        ///   &lt;li&gt;`lecture` - Lecture&lt;/li&gt;<br/>
        ///   &lt;li&gt;`meeting` - Meeting&lt;/li&gt;<br/>
        ///   &lt;li&gt;`mobile_phone` - Mobile Phone&lt;/li&gt;<br/>
        ///   &lt;li&gt;`music` - Music&lt;/li&gt;<br/>
        ///   &lt;li&gt;`podcast` - Podcast&lt;/li&gt;<br/>
        ///   &lt;li&gt;`studio` - Studio&lt;/li&gt;<br/>
        ///   &lt;li&gt;`voice_over` - Voice Over&lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// Example: studio
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DolbyEnhancementOptions(
            global::G.DolbyEnhancementOptionsPreset preset)
        {
            this.Preset = preset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DolbyEnhancementOptions" /> class.
        /// </summary>
        public DolbyEnhancementOptions()
        {
        }
    }
}
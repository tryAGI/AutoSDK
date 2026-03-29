//HintName: G.Models.ElevenLabsGeneratedAsset.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Generate assets using ElevenLabs. ElevenLabs provide a text-to-speech service. The ElevenLabs provider works on a bring-your-own-key basis, credentials are required and must be added via the  [dashboard](https://dashboard.shotstack.io/integrations/elevenlabs), not in the request.
    /// </summary>
    public sealed partial class ElevenLabsGeneratedAsset
    {
        /// <summary>
        /// The name of the provider - set to `elevenlabs` for ElevenLabs.<br/>
        /// Default Value: elevenlabs
        /// </summary>
        /// <default>global::G.ElevenLabsGeneratedAssetProvider.Elevenlabs</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ElevenLabsGeneratedAssetProviderJsonConverter))]
        public global::G.ElevenLabsGeneratedAssetProvider Provider { get; set; } = global::G.ElevenLabsGeneratedAssetProvider.Elevenlabs;

        /// <summary>
        /// Generate assets using the third party ElevenLabs provider AI services.<br/>
        /// The following AI generation services are available: &lt;ul&gt;<br/>
        ///   &lt;li&gt;&lt;a href="#tocs_elevenlabstexttospeechoptions"&gt;ElevenLabsTextToSpeechOptions&lt;/a&gt;&lt;/li&gt;<br/>
        /// &lt;/ul&gt;
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ElevenLabsTextToSpeechOptions Options { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ElevenLabsGeneratedAsset" /> class.
        /// </summary>
        /// <param name="options">
        /// Generate assets using the third party ElevenLabs provider AI services.<br/>
        /// The following AI generation services are available: &lt;ul&gt;<br/>
        ///   &lt;li&gt;&lt;a href="#tocs_elevenlabstexttospeechoptions"&gt;ElevenLabsTextToSpeechOptions&lt;/a&gt;&lt;/li&gt;<br/>
        /// &lt;/ul&gt;
        /// </param>
        /// <param name="provider">
        /// The name of the provider - set to `elevenlabs` for ElevenLabs.<br/>
        /// Default Value: elevenlabs
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ElevenLabsGeneratedAsset(
            global::G.ElevenLabsTextToSpeechOptions options,
            global::G.ElevenLabsGeneratedAssetProvider provider = global::G.ElevenLabsGeneratedAssetProvider.Elevenlabs)
        {
            this.Provider = provider;
            this.Options = options ?? throw new global::System.ArgumentNullException(nameof(options));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ElevenLabsGeneratedAsset" /> class.
        /// </summary>
        public ElevenLabsGeneratedAsset()
        {
        }
    }
}
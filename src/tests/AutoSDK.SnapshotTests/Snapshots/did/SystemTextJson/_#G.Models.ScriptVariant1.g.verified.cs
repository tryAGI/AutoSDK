//HintName: G.Models.ScriptVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScriptVariant1
    {
        /// <summary>
        /// The type of the script.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ScriptVariant1TypeJsonConverter))]
        public global::G.ScriptVariant1Type Type { get; set; }

        /// <summary>
        /// Should subtitles be created.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subtitles")]
        public bool? Subtitles { get; set; }

        /// <summary>
        /// text-to-speech provider from list of supported providers. default is microsoft tts
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.ScriptVariant1ProviderMicrosoft, global::G.ScriptVariant1ProviderElevenLabs, global::G.ScriptVariant1ProviderAmazon, global::G.ScriptVariant1ProviderGoogle, global::G.ScriptVariant1ProviderOpenAI>))]
        public global::G.AnyOf<global::G.ScriptVariant1ProviderMicrosoft, global::G.ScriptVariant1ProviderElevenLabs, global::G.ScriptVariant1ProviderAmazon, global::G.ScriptVariant1ProviderGoogle, global::G.ScriptVariant1ProviderOpenAI>? Provider { get; set; }

        /// <summary>
        /// The input text that will be synthesized to an audio file.<br/>
        /// Note that each provider has its own limitations on the text length.<br/>
        /// Maximum 40K characters (10K excluding SSML tags).<br/>
        /// Default Value: Making videos is easy with D-ID<br/>
        /// Example: Making videos is easy with D-ID
        /// </summary>
        /// <example>Making videos is easy with D-ID</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public string? Input { get; set; }

        /// <summary>
        /// Is the text provided in ssml form.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ssml")]
        public bool? Ssml { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScriptVariant1" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the script.
        /// </param>
        /// <param name="subtitles">
        /// Should subtitles be created.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="provider">
        /// text-to-speech provider from list of supported providers. default is microsoft tts
        /// </param>
        /// <param name="input">
        /// The input text that will be synthesized to an audio file.<br/>
        /// Note that each provider has its own limitations on the text length.<br/>
        /// Maximum 40K characters (10K excluding SSML tags).<br/>
        /// Default Value: Making videos is easy with D-ID<br/>
        /// Example: Making videos is easy with D-ID
        /// </param>
        /// <param name="ssml">
        /// Is the text provided in ssml form.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScriptVariant1(
            global::G.ScriptVariant1Type type,
            bool? subtitles,
            global::G.AnyOf<global::G.ScriptVariant1ProviderMicrosoft, global::G.ScriptVariant1ProviderElevenLabs, global::G.ScriptVariant1ProviderAmazon, global::G.ScriptVariant1ProviderGoogle, global::G.ScriptVariant1ProviderOpenAI>? provider,
            string? input,
            bool? ssml)
        {
            this.Type = type;
            this.Subtitles = subtitles;
            this.Provider = provider;
            this.Input = input;
            this.Ssml = ssml;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScriptVariant1" /> class.
        /// </summary>
        public ScriptVariant1()
        {
        }
    }
}
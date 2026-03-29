//HintName: G.Models.CreateTalkRequestScriptVariant12.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTalkRequestScriptVariant12
    {
        /// <summary>
        /// The type of the script.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.CreateTalkRequestScriptVariant1Type2 Type { get; set; }

        /// <summary>
        /// Should subtitles be created.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("subtitles")]
        public bool? Subtitles { get; set; }

        /// <summary>
        /// text-to-speech provider from list of supported providers. default is microsoft tts
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        public global::G.AnyOf<global::G.CreateTalkRequestScriptVariant1ProviderMicrosoft2, global::G.CreateTalkRequestScriptVariant1ProviderElevenLabs2, global::G.CreateTalkRequestScriptVariant1ProviderAmazon2, global::G.CreateTalkRequestScriptVariant1ProviderGoogle2, global::G.CreateTalkRequestScriptVariant1ProviderOpenAI2>? Provider { get; set; }

        /// <summary>
        /// The input text that will be synthesized to an audio file.<br/>
        /// Note that each provider has its own limitations on the text length.<br/>
        /// Maximum 40K characters (10K excluding SSML tags).<br/>
        /// Default Value: Making videos is easy with D-ID<br/>
        /// Example: Making videos is easy with D-ID
        /// </summary>
        /// <example>Making videos is easy with D-ID</example>
        [global::Newtonsoft.Json.JsonProperty("input")]
        public string? Input { get; set; }

        /// <summary>
        /// Is the text provided in ssml form.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ssml")]
        public bool? Ssml { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTalkRequestScriptVariant12" /> class.
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
        public CreateTalkRequestScriptVariant12(
            global::G.CreateTalkRequestScriptVariant1Type2 type,
            bool? subtitles,
            global::G.AnyOf<global::G.CreateTalkRequestScriptVariant1ProviderMicrosoft2, global::G.CreateTalkRequestScriptVariant1ProviderElevenLabs2, global::G.CreateTalkRequestScriptVariant1ProviderAmazon2, global::G.CreateTalkRequestScriptVariant1ProviderGoogle2, global::G.CreateTalkRequestScriptVariant1ProviderOpenAI2>? provider,
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
        /// Initializes a new instance of the <see cref="CreateTalkRequestScriptVariant12" /> class.
        /// </summary>
        public CreateTalkRequestScriptVariant12()
        {
        }
    }
}
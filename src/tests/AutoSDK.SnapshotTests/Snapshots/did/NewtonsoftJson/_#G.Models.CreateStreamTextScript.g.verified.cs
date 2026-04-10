//HintName: G.Models.CreateStreamTextScript.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateStreamTextScript
    {
        /// <summary>
        /// The type of the script.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateStreamTextScriptTypeJsonConverter))]
        public global::G.CreateStreamTextScriptType Type { get; set; }

        /// <summary>
        /// text-to-speech provider from list of supported providers. default is microsoft tts
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        public global::G.AnyOf<global::G.CreateStreamTextScriptProviderMicrosoft, global::G.CreateStreamTextScriptProviderElevenLabs, global::G.CreateStreamTextScriptProviderOpenAI>? Provider { get; set; }

        /// <summary>
        /// The input text that will be synthesized to an audio file.<br/>
        /// Note that each provider has its own limitations on the text length.<br/>
        /// Example: This is an example text
        /// </summary>
        /// <example>This is an example text</example>
        [global::Newtonsoft.Json.JsonProperty("input", Required = global::Newtonsoft.Json.Required.Always)]
        public string Input { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="CreateStreamTextScript" /> class.
        /// </summary>
        /// <param name="input">
        /// The input text that will be synthesized to an audio file.<br/>
        /// Note that each provider has its own limitations on the text length.<br/>
        /// Example: This is an example text
        /// </param>
        /// <param name="type">
        /// The type of the script.
        /// </param>
        /// <param name="provider">
        /// text-to-speech provider from list of supported providers. default is microsoft tts
        /// </param>
        /// <param name="ssml">
        /// Is the text provided in ssml form.<br/>
        /// Default Value: false
        /// </param>
        public CreateStreamTextScript(
            string input,
            global::G.CreateStreamTextScriptType type,
            global::G.AnyOf<global::G.CreateStreamTextScriptProviderMicrosoft, global::G.CreateStreamTextScriptProviderElevenLabs, global::G.CreateStreamTextScriptProviderOpenAI>? provider,
            bool? ssml)
        {
            this.Type = type;
            this.Provider = provider;
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Ssml = ssml;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStreamTextScript" /> class.
        /// </summary>
        public CreateStreamTextScript()
        {
        }
    }
}
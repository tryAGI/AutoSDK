//HintName: G.Models.CreateTalkStreamRequestScriptVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTalkStreamRequestScriptVariant1
    {
        /// <summary>
        /// The type of the script.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateTalkStreamRequestScriptVariant1TypeJsonConverter))]
        public global::G.CreateTalkStreamRequestScriptVariant1Type Type { get; set; }

        /// <summary>
        /// text-to-speech provider from list of supported providers. default is microsoft tts
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.CreateTalkStreamRequestScriptVariant1ProviderMicrosoft, global::G.CreateTalkStreamRequestScriptVariant1ProviderElevenLabs, global::G.CreateTalkStreamRequestScriptVariant1ProviderOpenAI>))]
        public global::G.AnyOf<global::G.CreateTalkStreamRequestScriptVariant1ProviderMicrosoft, global::G.CreateTalkStreamRequestScriptVariant1ProviderElevenLabs, global::G.CreateTalkStreamRequestScriptVariant1ProviderOpenAI>? Provider { get; set; }

        /// <summary>
        /// The input text that will be synthesized to an audio file.<br/>
        /// Note that each provider has its own limitations on the text length.<br/>
        /// Example: This is an example text
        /// </summary>
        /// <example>This is an example text</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Input { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateTalkStreamRequestScriptVariant1" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTalkStreamRequestScriptVariant1(
            string input,
            global::G.CreateTalkStreamRequestScriptVariant1Type type,
            global::G.AnyOf<global::G.CreateTalkStreamRequestScriptVariant1ProviderMicrosoft, global::G.CreateTalkStreamRequestScriptVariant1ProviderElevenLabs, global::G.CreateTalkStreamRequestScriptVariant1ProviderOpenAI>? provider,
            bool? ssml)
        {
            this.Type = type;
            this.Provider = provider;
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Ssml = ssml;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTalkStreamRequestScriptVariant1" /> class.
        /// </summary>
        public CreateTalkStreamRequestScriptVariant1()
        {
        }
    }
}
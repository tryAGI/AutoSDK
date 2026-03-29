//HintName: G.Models.OpenAiTextGeneratorOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Options for the OpenAI text-generator service. Set a text prompt that will be used to generate a new body of text. The output will be generated as a text (txt) file available at the URL returned in the response.
    /// </summary>
    public sealed partial class OpenAiTextGeneratorOptions
    {
        /// <summary>
        /// The type of asset to generate - set to `text-generator` for text generation.<br/>
        /// Default Value: text-generator
        /// </summary>
        /// <default>global::G.OpenAiTextGeneratorOptionsType.TextGenerator</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OpenAiTextGeneratorOptionsTypeJsonConverter))]
        public global::G.OpenAiTextGeneratorOptionsType Type { get; set; } = global::G.OpenAiTextGeneratorOptionsType.TextGenerator;

        /// <summary>
        /// The text prompt to generate text from.<br/>
        /// Example: Generate a short script for a 15 second video describing the benefits of the Shotstack API
        /// </summary>
        /// <example>Generate a short script for a 15 second video describing the benefits of the Shotstack API</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// The model to use for generating the text. Select from the list of available models: &lt;ul&gt;<br/>
        ///   &lt;li&gt;`gpt-3.5-turbo`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`gpt-4`&lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// Example: gpt-4
        /// </summary>
        /// <example>gpt-4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OpenAiTextGeneratorOptionsModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OpenAiTextGeneratorOptionsModel Model { get; set; }

        /// <summary>
        /// The system prompt to use for generating the text. This is an optional prompt that can be used to provide context or additional information to the model.<br/>
        /// Example: You are a professional script writer and film maker
        /// </summary>
        /// <example>You are a professional script writer and film maker</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("systemPrompt")]
        public string? SystemPrompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAiTextGeneratorOptions" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The text prompt to generate text from.<br/>
        /// Example: Generate a short script for a 15 second video describing the benefits of the Shotstack API
        /// </param>
        /// <param name="model">
        /// The model to use for generating the text. Select from the list of available models: &lt;ul&gt;<br/>
        ///   &lt;li&gt;`gpt-3.5-turbo`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`gpt-4`&lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// Example: gpt-4
        /// </param>
        /// <param name="systemPrompt">
        /// The system prompt to use for generating the text. This is an optional prompt that can be used to provide context or additional information to the model.<br/>
        /// Example: You are a professional script writer and film maker
        /// </param>
        /// <param name="type">
        /// The type of asset to generate - set to `text-generator` for text generation.<br/>
        /// Default Value: text-generator
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAiTextGeneratorOptions(
            string prompt,
            global::G.OpenAiTextGeneratorOptionsModel model,
            string? systemPrompt,
            global::G.OpenAiTextGeneratorOptionsType type = global::G.OpenAiTextGeneratorOptionsType.TextGenerator)
        {
            this.Type = type;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Model = model;
            this.SystemPrompt = systemPrompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAiTextGeneratorOptions" /> class.
        /// </summary>
        public OpenAiTextGeneratorOptions()
        {
        }
    }
}
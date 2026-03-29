//HintName: G.Models.ShotstackTextGeneratorOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Options for the Shotstack text-generator service. Set a text prompt that will be used to generate a new body of text. The output will be generated as a text (txt) file available at the URL returned in the response.
    /// </summary>
    public sealed partial class ShotstackTextGeneratorOptions
    {
        /// <summary>
        /// The type of asset to generate - set to `text-generator` for text generation.<br/>
        /// Default Value: text-generator
        /// </summary>
        /// <default>global::G.ShotstackTextGeneratorOptionsType.TextGenerator</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ShotstackTextGeneratorOptionsTypeJsonConverter))]
        public global::G.ShotstackTextGeneratorOptionsType Type { get; set; } = global::G.ShotstackTextGeneratorOptionsType.TextGenerator;

        /// <summary>
        /// The text prompt to generate text from.<br/>
        /// Example: Generate a short script for a 15 second video describing the benefits of the Shotstack API
        /// </summary>
        /// <example>Generate a short script for a 15 second video describing the benefits of the Shotstack API</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShotstackTextGeneratorOptions" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The text prompt to generate text from.<br/>
        /// Example: Generate a short script for a 15 second video describing the benefits of the Shotstack API
        /// </param>
        /// <param name="type">
        /// The type of asset to generate - set to `text-generator` for text generation.<br/>
        /// Default Value: text-generator
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ShotstackTextGeneratorOptions(
            string prompt,
            global::G.ShotstackTextGeneratorOptionsType type = global::G.ShotstackTextGeneratorOptionsType.TextGenerator)
        {
            this.Type = type;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShotstackTextGeneratorOptions" /> class.
        /// </summary>
        public ShotstackTextGeneratorOptions()
        {
        }
    }
}
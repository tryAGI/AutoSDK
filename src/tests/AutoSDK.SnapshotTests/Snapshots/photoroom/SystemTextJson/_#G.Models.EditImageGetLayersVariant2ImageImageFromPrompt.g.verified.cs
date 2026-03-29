//HintName: G.Models.EditImageGetLayersVariant2ImageImageFromPrompt.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Instead of providing an image, you can provide a prompt to generate an image.
    /// </summary>
    public sealed partial class EditImageGetLayersVariant2ImageImageFromPrompt
    {
        /// <summary>
        /// The prompt to use for generating the image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Seed used to run the AI image generator. Can be used to get similar looking results for the same prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public double? Seed { get; set; }

        /// <summary>
        /// Supported sizes for AI image generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EditImageGetLayersVariant2ImageImageFromPromptSizeJsonConverter))]
        public global::G.EditImageGetLayersVariant2ImageImageFromPromptSize? Size { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditImageGetLayersVariant2ImageImageFromPrompt" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The prompt to use for generating the image.
        /// </param>
        /// <param name="seed">
        /// Seed used to run the AI image generator. Can be used to get similar looking results for the same prompt.
        /// </param>
        /// <param name="size">
        /// Supported sizes for AI image generation
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EditImageGetLayersVariant2ImageImageFromPrompt(
            string prompt,
            double? seed,
            global::G.EditImageGetLayersVariant2ImageImageFromPromptSize? size)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Seed = seed;
            this.Size = size;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditImageGetLayersVariant2ImageImageFromPrompt" /> class.
        /// </summary>
        public EditImageGetLayersVariant2ImageImageFromPrompt()
        {
        }
    }
}
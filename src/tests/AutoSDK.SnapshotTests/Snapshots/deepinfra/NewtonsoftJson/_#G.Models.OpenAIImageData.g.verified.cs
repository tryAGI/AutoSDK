//HintName: G.Models.OpenAIImageData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAIImageData
    {
        /// <summary>
        /// The base64-encoded image data
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("b64_json", Required = global::Newtonsoft.Json.Required.Always)]
        public string B64Json { get; set; } = default!;

        /// <summary>
        /// The prompt used to generate this image
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("revised_prompt")]
        public string? RevisedPrompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIImageData" /> class.
        /// </summary>
        /// <param name="b64Json">
        /// The base64-encoded image data
        /// </param>
        /// <param name="revisedPrompt">
        /// The prompt used to generate this image
        /// </param>
        public OpenAIImageData(
            string b64Json,
            string? revisedPrompt)
        {
            this.B64Json = b64Json ?? throw new global::System.ArgumentNullException(nameof(b64Json));
            this.RevisedPrompt = revisedPrompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIImageData" /> class.
        /// </summary>
        public OpenAIImageData()
        {
        }
    }
}
//HintName: G.Models.GenerateResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response from direct LLM generation.
    /// </summary>
    public sealed partial class GenerateResponse
    {
        /// <summary>
        /// The LLM's response text
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public string Content { get; set; } = default!;

        /// <summary>
        /// The model that generated this response
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// Token usage statistics
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.LettaUsageStatistics Usage { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateResponse" /> class.
        /// </summary>
        /// <param name="content">
        /// The LLM's response text
        /// </param>
        /// <param name="model">
        /// The model that generated this response
        /// </param>
        /// <param name="usage">
        /// Token usage statistics
        /// </param>
        public GenerateResponse(
            string content,
            string model,
            global::G.LettaUsageStatistics usage)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateResponse" /> class.
        /// </summary>
        public GenerateResponse()
        {
        }
    }
}
//HintName: G.Models.ChatCompletionUsageBreakdownModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionUsageBreakdownModel
    {
        /// <summary>
        /// The name/identifier of the model used
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// Usage statistics for the completion request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CompletionUsage Usage { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionUsageBreakdownModel" /> class.
        /// </summary>
        /// <param name="model">
        /// The name/identifier of the model used
        /// </param>
        /// <param name="usage">
        /// Usage statistics for the completion request.
        /// </param>
        public ChatCompletionUsageBreakdownModel(
            string model,
            global::G.CompletionUsage usage)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionUsageBreakdownModel" /> class.
        /// </summary>
        public ChatCompletionUsageBreakdownModel()
        {
        }
    }
}
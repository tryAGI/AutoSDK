//HintName: G.Models.ChatCompletionUsageBreakdown.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Usage statistics for compound AI completion requests.
    /// </summary>
    public sealed partial class ChatCompletionUsageBreakdown
    {
        /// <summary>
        /// List of models used in the request and their individual usage statistics
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("models", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ChatCompletionUsageBreakdownModel> Models { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionUsageBreakdown" /> class.
        /// </summary>
        /// <param name="models">
        /// List of models used in the request and their individual usage statistics
        /// </param>
        public ChatCompletionUsageBreakdown(
            global::System.Collections.Generic.IList<global::G.ChatCompletionUsageBreakdownModel> models)
        {
            this.Models = models ?? throw new global::System.ArgumentNullException(nameof(models));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionUsageBreakdown" /> class.
        /// </summary>
        public ChatCompletionUsageBreakdown()
        {
        }
    }
}
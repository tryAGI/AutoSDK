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
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ChatCompletionUsageBreakdownModel> Models { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionUsageBreakdown" /> class.
        /// </summary>
        /// <param name="models">
        /// List of models used in the request and their individual usage statistics
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
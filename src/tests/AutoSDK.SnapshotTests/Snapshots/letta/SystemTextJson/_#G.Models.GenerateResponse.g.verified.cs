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
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// The model that generated this response
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Token usage statistics
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.LettaUsageStatistics Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
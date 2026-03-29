//HintName: G.Models.Mono.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Mono
    {
        /// <summary>
        /// This is the combined recording url for the call. To enable, set `assistant.artifactPlan.recordingEnabled`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("combinedUrl")]
        public string? CombinedUrl { get; set; }

        /// <summary>
        /// This is the mono recording url for the assistant. To enable, set `assistant.artifactPlan.recordingEnabled`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistantUrl")]
        public string? AssistantUrl { get; set; }

        /// <summary>
        /// This is the mono recording url for the customer. To enable, set `assistant.artifactPlan.recordingEnabled`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customerUrl")]
        public string? CustomerUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Mono" /> class.
        /// </summary>
        /// <param name="combinedUrl">
        /// This is the combined recording url for the call. To enable, set `assistant.artifactPlan.recordingEnabled`.
        /// </param>
        /// <param name="assistantUrl">
        /// This is the mono recording url for the assistant. To enable, set `assistant.artifactPlan.recordingEnabled`.
        /// </param>
        /// <param name="customerUrl">
        /// This is the mono recording url for the customer. To enable, set `assistant.artifactPlan.recordingEnabled`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Mono(
            string? combinedUrl,
            string? assistantUrl,
            string? customerUrl)
        {
            this.CombinedUrl = combinedUrl;
            this.AssistantUrl = assistantUrl;
            this.CustomerUrl = customerUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Mono" /> class.
        /// </summary>
        public Mono()
        {
        }
    }
}
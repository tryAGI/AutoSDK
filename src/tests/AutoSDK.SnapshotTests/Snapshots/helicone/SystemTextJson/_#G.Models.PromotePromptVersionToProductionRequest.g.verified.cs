//HintName: G.Models.PromotePromptVersionToProductionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromotePromptVersionToProductionRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previousProductionVersionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PreviousProductionVersionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromotePromptVersionToProductionRequest" /> class.
        /// </summary>
        /// <param name="previousProductionVersionId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromotePromptVersionToProductionRequest(
            string previousProductionVersionId)
        {
            this.PreviousProductionVersionId = previousProductionVersionId ?? throw new global::System.ArgumentNullException(nameof(previousProductionVersionId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromotePromptVersionToProductionRequest" /> class.
        /// </summary>
        public PromotePromptVersionToProductionRequest()
        {
        }
    }
}
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
        [global::Newtonsoft.Json.JsonProperty("previousProductionVersionId", Required = global::Newtonsoft.Json.Required.Always)]
        public string PreviousProductionVersionId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromotePromptVersionToProductionRequest" /> class.
        /// </summary>
        /// <param name="previousProductionVersionId"></param>
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
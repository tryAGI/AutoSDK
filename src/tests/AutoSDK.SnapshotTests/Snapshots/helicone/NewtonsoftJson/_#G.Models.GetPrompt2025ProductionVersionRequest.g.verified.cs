//HintName: G.Models.GetPrompt2025ProductionVersionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetPrompt2025ProductionVersionRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("promptId", Required = global::Newtonsoft.Json.Required.Always)]
        public string PromptId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPrompt2025ProductionVersionRequest" /> class.
        /// </summary>
        /// <param name="promptId"></param>
        public GetPrompt2025ProductionVersionRequest(
            string promptId)
        {
            this.PromptId = promptId ?? throw new global::System.ArgumentNullException(nameof(promptId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPrompt2025ProductionVersionRequest" /> class.
        /// </summary>
        public GetPrompt2025ProductionVersionRequest()
        {
        }
    }
}
//HintName: G.Models.OptimizePromptResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response from optimizing a prompt.
    /// </summary>
    public sealed partial class OptimizePromptResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("optimization_job_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid OptimizationJobId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OptimizePromptResponse" /> class.
        /// </summary>
        /// <param name="optimizationJobId"></param>
        public OptimizePromptResponse(
            global::System.Guid optimizationJobId)
        {
            this.OptimizationJobId = optimizationJobId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OptimizePromptResponse" /> class.
        /// </summary>
        public OptimizePromptResponse()
        {
        }
    }
}
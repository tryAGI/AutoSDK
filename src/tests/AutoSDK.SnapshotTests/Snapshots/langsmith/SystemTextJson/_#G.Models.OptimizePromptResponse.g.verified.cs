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
        [global::System.Text.Json.Serialization.JsonPropertyName("optimization_job_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid OptimizationJobId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OptimizePromptResponse" /> class.
        /// </summary>
        /// <param name="optimizationJobId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
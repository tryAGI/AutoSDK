//HintName: G.Models.CommandContext.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CommandContext
    {
        /// <summary>
        /// Server-side request ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Identifier of pipeline connected to operation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pipeline_id")]
        public string? PipelineId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandContext" /> class.
        /// </summary>
        /// <param name="requestId">
        /// Server-side request ID
        /// </param>
        /// <param name="pipelineId">
        /// Identifier of pipeline connected to operation
        /// </param>
        public CommandContext(
            string? requestId,
            string? pipelineId)
        {
            this.RequestId = requestId;
            this.PipelineId = pipelineId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandContext" /> class.
        /// </summary>
        public CommandContext()
        {
        }
    }
}
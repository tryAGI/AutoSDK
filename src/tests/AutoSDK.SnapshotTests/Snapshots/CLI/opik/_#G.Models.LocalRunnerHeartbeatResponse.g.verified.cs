//HintName: G.Models.LocalRunnerHeartbeatResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LocalRunnerHeartbeatResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cancelled_job_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? CancelledJobIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalRunnerHeartbeatResponse" /> class.
        /// </summary>
        /// <param name="cancelledJobIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LocalRunnerHeartbeatResponse(
            global::System.Collections.Generic.IList<global::System.Guid>? cancelledJobIds)
        {
            this.CancelledJobIds = cancelledJobIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalRunnerHeartbeatResponse" /> class.
        /// </summary>
        public LocalRunnerHeartbeatResponse()
        {
        }
    }
}
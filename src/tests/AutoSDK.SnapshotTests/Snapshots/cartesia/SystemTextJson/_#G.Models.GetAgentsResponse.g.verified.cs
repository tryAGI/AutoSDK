//HintName: G.Models.GetAgentsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAgentsResponse
    {
        /// <summary>
        /// The summaries of the agents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summaries")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.AgentSummary> Summaries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgentsResponse" /> class.
        /// </summary>
        /// <param name="summaries">
        /// The summaries of the agents.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAgentsResponse(
            global::System.Collections.Generic.IList<global::G.AgentSummary> summaries)
        {
            this.Summaries = summaries ?? throw new global::System.ArgumentNullException(nameof(summaries));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgentsResponse" /> class.
        /// </summary>
        public GetAgentsResponse()
        {
        }
    }
}
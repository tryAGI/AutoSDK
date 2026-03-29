//HintName: G.Models.PipelinesListPipelineSyncHistoryResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PipelinesListPipelineSyncHistoryResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("runs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.PipelinesListPipelineSyncHistoryResponseRun> Runs { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next_page_token")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinesListPipelineSyncHistoryResponse" /> class.
        /// </summary>
        /// <param name="runs"></param>
        /// <param name="nextPageToken"></param>
        public PipelinesListPipelineSyncHistoryResponse(
            global::System.Collections.Generic.IList<global::G.PipelinesListPipelineSyncHistoryResponseRun> runs,
            string? nextPageToken)
        {
            this.Runs = runs ?? throw new global::System.ArgumentNullException(nameof(runs));
            this.NextPageToken = nextPageToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinesListPipelineSyncHistoryResponse" /> class.
        /// </summary>
        public PipelinesListPipelineSyncHistoryResponse()
        {
        }
    }
}
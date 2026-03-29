//HintName: G.Models.PutLogsExportsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PutLogsExportsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workspace_id")]
        public string? WorkspaceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filters", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GenerationsFilterSchema Filters { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requested_data")]
        public global::System.Collections.Generic.IList<global::G.LogExportsRequestedDataItem>? RequestedData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PutLogsExportsRequest" /> class.
        /// </summary>
        /// <param name="filters"></param>
        /// <param name="workspaceId"></param>
        /// <param name="requestedData"></param>
        public PutLogsExportsRequest(
            global::G.GenerationsFilterSchema filters,
            string? workspaceId,
            global::System.Collections.Generic.IList<global::G.LogExportsRequestedDataItem>? requestedData)
        {
            this.WorkspaceId = workspaceId;
            this.Filters = filters ?? throw new global::System.ArgumentNullException(nameof(filters));
            this.RequestedData = requestedData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutLogsExportsRequest" /> class.
        /// </summary>
        public PutLogsExportsRequest()
        {
        }
    }
}
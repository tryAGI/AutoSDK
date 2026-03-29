//HintName: G.Models.CreateLogsExportsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateLogsExportsRequest
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
        [global::Newtonsoft.Json.JsonProperty("requested_data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.LogExportsRequestedDataItem> RequestedData { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLogsExportsRequest" /> class.
        /// </summary>
        /// <param name="filters"></param>
        /// <param name="requestedData"></param>
        /// <param name="workspaceId"></param>
        public CreateLogsExportsRequest(
            global::G.GenerationsFilterSchema filters,
            global::System.Collections.Generic.IList<global::G.LogExportsRequestedDataItem> requestedData,
            string? workspaceId)
        {
            this.WorkspaceId = workspaceId;
            this.Filters = filters ?? throw new global::System.ArgumentNullException(nameof(filters));
            this.RequestedData = requestedData ?? throw new global::System.ArgumentNullException(nameof(requestedData));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLogsExportsRequest" /> class.
        /// </summary>
        public CreateLogsExportsRequest()
        {
        }
    }
}
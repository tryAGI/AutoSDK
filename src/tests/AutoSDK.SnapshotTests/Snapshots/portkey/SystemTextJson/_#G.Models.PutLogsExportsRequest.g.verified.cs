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
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public string? WorkspaceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GenerationsFilterSchema Filters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requested_data")]
        public global::System.Collections.Generic.IList<global::G.LogExportsRequestedDataItem>? RequestedData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PutLogsExportsRequest" /> class.
        /// </summary>
        /// <param name="filters"></param>
        /// <param name="workspaceId"></param>
        /// <param name="requestedData"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
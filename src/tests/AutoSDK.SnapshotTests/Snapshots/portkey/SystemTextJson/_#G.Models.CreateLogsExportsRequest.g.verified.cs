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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.LogExportsRequestedDataItem> RequestedData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLogsExportsRequest" /> class.
        /// </summary>
        /// <param name="filters"></param>
        /// <param name="requestedData"></param>
        /// <param name="workspaceId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
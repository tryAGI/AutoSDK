//HintName: G.Models.FilterView.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FilterView
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filter_string")]
        public string? FilterString { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trace_filter_string")]
        public string? TraceFilterString { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tree_filter_string")]
        public string? TreeFilterString { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("display_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string DisplayName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("session_id")]
        public global::System.Guid? SessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterView" /> class.
        /// </summary>
        /// <param name="filterString"></param>
        /// <param name="traceFilterString"></param>
        /// <param name="treeFilterString"></param>
        /// <param name="displayName"></param>
        /// <param name="description"></param>
        /// <param name="id"></param>
        /// <param name="sessionId"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        public FilterView(
            string displayName,
            global::System.Guid id,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? filterString,
            string? traceFilterString,
            string? treeFilterString,
            string? description,
            global::System.Guid? sessionId)
        {
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Id = id;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.FilterString = filterString;
            this.TraceFilterString = traceFilterString;
            this.TreeFilterString = treeFilterString;
            this.Description = description;
            this.SessionId = sessionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterView" /> class.
        /// </summary>
        public FilterView()
        {
        }
    }
}
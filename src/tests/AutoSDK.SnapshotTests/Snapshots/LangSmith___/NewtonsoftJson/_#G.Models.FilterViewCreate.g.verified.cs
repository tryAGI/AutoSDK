//HintName: G.Models.FilterViewCreate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FilterViewCreate
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterViewCreate" /> class.
        /// </summary>
        /// <param name="filterString"></param>
        /// <param name="traceFilterString"></param>
        /// <param name="treeFilterString"></param>
        /// <param name="displayName"></param>
        /// <param name="description"></param>
        public FilterViewCreate(
            string displayName,
            string? filterString,
            string? traceFilterString,
            string? treeFilterString,
            string? description)
        {
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.FilterString = filterString;
            this.TraceFilterString = traceFilterString;
            this.TreeFilterString = treeFilterString;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterViewCreate" /> class.
        /// </summary>
        public FilterViewCreate()
        {
        }
    }
}
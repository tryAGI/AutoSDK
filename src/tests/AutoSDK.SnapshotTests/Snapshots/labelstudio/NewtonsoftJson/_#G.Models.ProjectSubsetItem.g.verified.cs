//HintName: G.Models.ProjectSubsetItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectSubsetItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("columns_schema")]
        public global::System.Collections.Generic.IList<object>? ColumnsSchema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("count", Required = global::Newtonsoft.Json.Required.Always)]
        public int Count { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("subset", Required = global::Newtonsoft.Json.Required.Always)]
        public string Subset { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectSubsetItem" /> class.
        /// </summary>
        /// <param name="count"></param>
        /// <param name="subset"></param>
        /// <param name="columnsSchema"></param>
        public ProjectSubsetItem(
            int count,
            string subset,
            global::System.Collections.Generic.IList<object>? columnsSchema)
        {
            this.ColumnsSchema = columnsSchema;
            this.Count = count;
            this.Subset = subset ?? throw new global::System.ArgumentNullException(nameof(subset));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectSubsetItem" /> class.
        /// </summary>
        public ProjectSubsetItem()
        {
        }
    }
}
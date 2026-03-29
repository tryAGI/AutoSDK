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
        [global::System.Text.Json.Serialization.JsonPropertyName("columns_schema")]
        public global::System.Collections.Generic.IList<object>? ColumnsSchema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subset")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Subset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectSubsetItem" /> class.
        /// </summary>
        /// <param name="count"></param>
        /// <param name="subset"></param>
        /// <param name="columnsSchema"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
//HintName: G.Models.GetPrompts2025Request.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetPrompts2025Request
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pageSize")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PageSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Page { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tagsFilter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> TagsFilter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Search { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPrompts2025Request" /> class.
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="page"></param>
        /// <param name="tagsFilter"></param>
        /// <param name="search"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetPrompts2025Request(
            double pageSize,
            double page,
            global::System.Collections.Generic.IList<string> tagsFilter,
            string search)
        {
            this.PageSize = pageSize;
            this.Page = page;
            this.TagsFilter = tagsFilter ?? throw new global::System.ArgumentNullException(nameof(tagsFilter));
            this.Search = search ?? throw new global::System.ArgumentNullException(nameof(search));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPrompts2025Request" /> class.
        /// </summary>
        public GetPrompts2025Request()
        {
        }
    }
}
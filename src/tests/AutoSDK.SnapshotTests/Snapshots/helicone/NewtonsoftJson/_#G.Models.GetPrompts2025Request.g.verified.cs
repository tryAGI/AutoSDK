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
        [global::Newtonsoft.Json.JsonProperty("pageSize", Required = global::Newtonsoft.Json.Required.Always)]
        public double PageSize { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page", Required = global::Newtonsoft.Json.Required.Always)]
        public double Page { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tagsFilter", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> TagsFilter { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("search", Required = global::Newtonsoft.Json.Required.Always)]
        public string Search { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPrompts2025Request" /> class.
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="page"></param>
        /// <param name="tagsFilter"></param>
        /// <param name="search"></param>
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
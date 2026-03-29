//HintName: G.Models.PagedResponseGeneration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PagedResponseGeneration
    {
        /// <summary>
        /// Paging information.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page_info", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PageInfo PageInfo { get; set; } = default!;

        /// <summary>
        /// Page data.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Generation> Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PagedResponseGeneration" /> class.
        /// </summary>
        /// <param name="pageInfo">
        /// Paging information.
        /// </param>
        /// <param name="data">
        /// Page data.
        /// </param>
        public PagedResponseGeneration(
            global::G.PageInfo pageInfo,
            global::System.Collections.Generic.IList<global::G.Generation> data)
        {
            this.PageInfo = pageInfo ?? throw new global::System.ArgumentNullException(nameof(pageInfo));
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PagedResponseGeneration" /> class.
        /// </summary>
        public PagedResponseGeneration()
        {
        }
    }
}
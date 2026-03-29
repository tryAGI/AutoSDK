//HintName: G.Models.PaginationMeta.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PaginationMeta
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("itemsPerPage", Required = global::Newtonsoft.Json.Required.Always)]
        public double ItemsPerPage { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("totalItems", Required = global::Newtonsoft.Json.Required.Always)]
        public double TotalItems { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("currentPage", Required = global::Newtonsoft.Json.Required.Always)]
        public double CurrentPage { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("itemsBeyondRetention")]
        public bool? ItemsBeyondRetention { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAtLe")]
        public global::System.DateTime? CreatedAtLe { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAtGe")]
        public global::System.DateTime? CreatedAtGe { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginationMeta" /> class.
        /// </summary>
        /// <param name="itemsPerPage"></param>
        /// <param name="totalItems"></param>
        /// <param name="currentPage"></param>
        /// <param name="itemsBeyondRetention"></param>
        /// <param name="createdAtLe"></param>
        /// <param name="createdAtGe"></param>
        public PaginationMeta(
            double itemsPerPage,
            double totalItems,
            double currentPage,
            bool? itemsBeyondRetention,
            global::System.DateTime? createdAtLe,
            global::System.DateTime? createdAtGe)
        {
            this.ItemsPerPage = itemsPerPage;
            this.TotalItems = totalItems;
            this.CurrentPage = currentPage;
            this.ItemsBeyondRetention = itemsBeyondRetention;
            this.CreatedAtLe = createdAtLe;
            this.CreatedAtGe = createdAtGe;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginationMeta" /> class.
        /// </summary>
        public PaginationMeta()
        {
        }
    }
}
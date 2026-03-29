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
        [global::System.Text.Json.Serialization.JsonPropertyName("itemsPerPage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ItemsPerPage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalItems")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalItems { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currentPage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CurrentPage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("itemsBeyondRetention")]
        public bool? ItemsBeyondRetention { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAtLe")]
        public global::System.DateTime? CreatedAtLe { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAtGe")]
        public global::System.DateTime? CreatedAtGe { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
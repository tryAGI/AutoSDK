//HintName: G.Models.GetEvalRunPaginatedDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetEvalRunPaginatedDTO
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// This is the page number to return. Defaults to 1.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page")]
        public double? Page { get; set; }

        /// <summary>
        /// This is the sort order for pagination. Defaults to 'DESC'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sortOrder")]
        public global::G.GetEvalRunPaginatedDTOSortOrder? SortOrder { get; set; }

        /// <summary>
        /// This is the maximum number of items to return. Defaults to 100.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit")]
        public double? Limit { get; set; }

        /// <summary>
        /// This will return items where the createdAt is greater than the specified value.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAtGt")]
        public global::System.DateTime? CreatedAtGt { get; set; }

        /// <summary>
        /// This will return items where the createdAt is less than the specified value.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAtLt")]
        public global::System.DateTime? CreatedAtLt { get; set; }

        /// <summary>
        /// This will return items where the createdAt is greater than or equal to the specified value.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAtGe")]
        public global::System.DateTime? CreatedAtGe { get; set; }

        /// <summary>
        /// This will return items where the createdAt is less than or equal to the specified value.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAtLe")]
        public global::System.DateTime? CreatedAtLe { get; set; }

        /// <summary>
        /// This will return items where the updatedAt is greater than the specified value.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updatedAtGt")]
        public global::System.DateTime? UpdatedAtGt { get; set; }

        /// <summary>
        /// This will return items where the updatedAt is less than the specified value.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updatedAtLt")]
        public global::System.DateTime? UpdatedAtLt { get; set; }

        /// <summary>
        /// This will return items where the updatedAt is greater than or equal to the specified value.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updatedAtGe")]
        public global::System.DateTime? UpdatedAtGe { get; set; }

        /// <summary>
        /// This will return items where the updatedAt is less than or equal to the specified value.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updatedAtLe")]
        public global::System.DateTime? UpdatedAtLe { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetEvalRunPaginatedDTO" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="page">
        /// This is the page number to return. Defaults to 1.
        /// </param>
        /// <param name="sortOrder">
        /// This is the sort order for pagination. Defaults to 'DESC'.
        /// </param>
        /// <param name="limit">
        /// This is the maximum number of items to return. Defaults to 100.
        /// </param>
        /// <param name="createdAtGt">
        /// This will return items where the createdAt is greater than the specified value.
        /// </param>
        /// <param name="createdAtLt">
        /// This will return items where the createdAt is less than the specified value.
        /// </param>
        /// <param name="createdAtGe">
        /// This will return items where the createdAt is greater than or equal to the specified value.
        /// </param>
        /// <param name="createdAtLe">
        /// This will return items where the createdAt is less than or equal to the specified value.
        /// </param>
        /// <param name="updatedAtGt">
        /// This will return items where the updatedAt is greater than the specified value.
        /// </param>
        /// <param name="updatedAtLt">
        /// This will return items where the updatedAt is less than the specified value.
        /// </param>
        /// <param name="updatedAtGe">
        /// This will return items where the updatedAt is greater than or equal to the specified value.
        /// </param>
        /// <param name="updatedAtLe">
        /// This will return items where the updatedAt is less than or equal to the specified value.
        /// </param>
        public GetEvalRunPaginatedDTO(
            string? id,
            double? page,
            global::G.GetEvalRunPaginatedDTOSortOrder? sortOrder,
            double? limit,
            global::System.DateTime? createdAtGt,
            global::System.DateTime? createdAtLt,
            global::System.DateTime? createdAtGe,
            global::System.DateTime? createdAtLe,
            global::System.DateTime? updatedAtGt,
            global::System.DateTime? updatedAtLt,
            global::System.DateTime? updatedAtGe,
            global::System.DateTime? updatedAtLe)
        {
            this.Id = id;
            this.Page = page;
            this.SortOrder = sortOrder;
            this.Limit = limit;
            this.CreatedAtGt = createdAtGt;
            this.CreatedAtLt = createdAtLt;
            this.CreatedAtGe = createdAtGe;
            this.CreatedAtLe = createdAtLe;
            this.UpdatedAtGt = updatedAtGt;
            this.UpdatedAtLt = updatedAtLt;
            this.UpdatedAtGe = updatedAtGe;
            this.UpdatedAtLe = updatedAtLe;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetEvalRunPaginatedDTO" /> class.
        /// </summary>
        public GetEvalRunPaginatedDTO()
        {
        }
    }
}
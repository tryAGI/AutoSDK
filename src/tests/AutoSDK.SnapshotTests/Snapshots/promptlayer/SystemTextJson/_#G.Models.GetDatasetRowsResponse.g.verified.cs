//HintName: G.Models.GetDatasetRowsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDatasetRowsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Ordered list of column names
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("columns")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Columns { get; set; }

        /// <summary>
        /// Array of rows, each row is an array of cells
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rows")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::G.GetDatasetRowsResponseRowItem>> Rows { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Page { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("per_page")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PerPage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Pages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDatasetRowsResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="message"></param>
        /// <param name="columns">
        /// Ordered list of column names
        /// </param>
        /// <param name="rows">
        /// Array of rows, each row is an array of cells
        /// </param>
        /// <param name="page"></param>
        /// <param name="perPage"></param>
        /// <param name="total"></param>
        /// <param name="pages"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDatasetRowsResponse(
            bool success,
            string message,
            global::System.Collections.Generic.IList<string> columns,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::G.GetDatasetRowsResponseRowItem>> rows,
            int page,
            int perPage,
            int total,
            int pages)
        {
            this.Success = success;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Columns = columns ?? throw new global::System.ArgumentNullException(nameof(columns));
            this.Rows = rows ?? throw new global::System.ArgumentNullException(nameof(rows));
            this.Page = page;
            this.PerPage = perPage;
            this.Total = total;
            this.Pages = pages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDatasetRowsResponse" /> class.
        /// </summary>
        public GetDatasetRowsResponse()
        {
        }
    }
}
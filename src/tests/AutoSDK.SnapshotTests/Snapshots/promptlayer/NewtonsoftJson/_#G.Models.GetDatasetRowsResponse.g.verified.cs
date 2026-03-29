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
        [global::Newtonsoft.Json.JsonProperty("success", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Success { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Ordered list of column names
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("columns", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Columns { get; set; } = default!;

        /// <summary>
        /// Array of rows, each row is an array of cells
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rows", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::G.GetDatasetRowsResponseRowItem>> Rows { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page", Required = global::Newtonsoft.Json.Required.Always)]
        public int Page { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("per_page", Required = global::Newtonsoft.Json.Required.Always)]
        public int PerPage { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total", Required = global::Newtonsoft.Json.Required.Always)]
        public int Total { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pages", Required = global::Newtonsoft.Json.Required.Always)]
        public int Pages { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
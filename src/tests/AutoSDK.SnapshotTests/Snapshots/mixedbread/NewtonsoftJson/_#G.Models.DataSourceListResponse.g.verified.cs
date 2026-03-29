//HintName: G.Models.DataSourceListResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A list of data sources with pagination.
    /// </summary>
    public sealed partial class DataSourceListResponse
    {
        /// <summary>
        /// Response model for cursor-based pagination.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pagination", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CursorPaginationResponse Pagination { get; set; } = default!;

        /// <summary>
        /// The list of data sources
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.DataSource> Data { get; set; } = default!;

        /// <summary>
        /// The object type of the response<br/>
        /// Default Value: list
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSourceListResponse" /> class.
        /// </summary>
        /// <param name="pagination">
        /// Response model for cursor-based pagination.
        /// </param>
        /// <param name="data">
        /// The list of data sources
        /// </param>
        /// <param name="object">
        /// The object type of the response<br/>
        /// Default Value: list
        /// </param>
        public DataSourceListResponse(
            global::G.CursorPaginationResponse pagination,
            global::System.Collections.Generic.IList<global::G.DataSource> data,
            string? @object)
        {
            this.Pagination = pagination ?? throw new global::System.ArgumentNullException(nameof(pagination));
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSourceListResponse" /> class.
        /// </summary>
        public DataSourceListResponse()
        {
        }
    }
}
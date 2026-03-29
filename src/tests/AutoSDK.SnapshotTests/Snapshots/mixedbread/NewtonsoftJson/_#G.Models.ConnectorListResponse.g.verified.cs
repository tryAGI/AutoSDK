//HintName: G.Models.ConnectorListResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A list of connectors with pagination.
    /// </summary>
    public sealed partial class ConnectorListResponse
    {
        /// <summary>
        /// Response model for cursor-based pagination.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pagination", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CursorPaginationResponse Pagination { get; set; } = default!;

        /// <summary>
        /// The list of connectors
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.DataSourceConnector> Data { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="ConnectorListResponse" /> class.
        /// </summary>
        /// <param name="pagination">
        /// Response model for cursor-based pagination.
        /// </param>
        /// <param name="data">
        /// The list of connectors
        /// </param>
        /// <param name="object">
        /// The object type of the response<br/>
        /// Default Value: list
        /// </param>
        public ConnectorListResponse(
            global::G.CursorPaginationResponse pagination,
            global::System.Collections.Generic.IList<global::G.DataSourceConnector> data,
            string? @object)
        {
            this.Pagination = pagination ?? throw new global::System.ArgumentNullException(nameof(pagination));
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorListResponse" /> class.
        /// </summary>
        public ConnectorListResponse()
        {
        }
    }
}
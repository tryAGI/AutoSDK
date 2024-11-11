//HintName: G.Models.ListConnectorsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListConnectorsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("connectors", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Connector> Connectors { get; set; } = default!;

        /// <summary>
        /// Total number of connectors.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_count")]
        public double? TotalCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListConnectorsResponse" /> class.
        /// </summary>
        /// <param name="connectors"></param>
        /// <param name="totalCount">
        /// Total number of connectors.<br/>
        /// Included only in responses
        /// </param>
        public ListConnectorsResponse(
            global::System.Collections.Generic.IList<global::G.Connector> connectors,
            double? totalCount)
        {
            this.Connectors = connectors ?? throw new global::System.ArgumentNullException(nameof(connectors));
            this.TotalCount = totalCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListConnectorsResponse" /> class.
        /// </summary>
        public ListConnectorsResponse()
        {
        }
    }
}
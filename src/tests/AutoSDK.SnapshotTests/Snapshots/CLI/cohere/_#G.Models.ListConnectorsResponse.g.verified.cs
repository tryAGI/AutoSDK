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
        [global::System.Text.Json.Serialization.JsonPropertyName("connectors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Connector> Connectors { get; set; }

        /// <summary>
        /// Total number of connectors.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public double? TotalCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListConnectorsResponse" /> class.
        /// </summary>
        /// <param name="connectors"></param>
        /// <param name="totalCount">
        /// Total number of connectors.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
//HintName: G.Models.GetConnectorsLogsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConnectorsLogsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("connector_logs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ConnectorLog> ConnectorLogs { get; set; } = default!;

        /// <summary>
        /// Total number of connector logs<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("total")]
        public double Total { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectorsLogsResponse" /> class.
        /// </summary>
        /// <param name="connectorLogs"></param>
        /// <param name="total">
        /// Total number of connector logs<br/>
        /// Included only in responses
        /// </param>
        public GetConnectorsLogsResponse(
            global::System.Collections.Generic.IList<global::G.ConnectorLog> connectorLogs,
            double total = default!)
        {
            this.ConnectorLogs = connectorLogs ?? throw new global::System.ArgumentNullException(nameof(connectorLogs));
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectorsLogsResponse" /> class.
        /// </summary>
        public GetConnectorsLogsResponse()
        {
        }
    }
}
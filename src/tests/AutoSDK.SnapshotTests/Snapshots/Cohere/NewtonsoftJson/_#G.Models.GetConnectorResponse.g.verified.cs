//HintName: G.Models.GetConnectorResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConnectorResponse
    {
        /// <summary>
        /// A connector allows you to integrate data sources with the '/chat' endpoint to create grounded generations with citations to the data source.<br/>
        /// documents to help answer users.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("connector", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Connector Connector { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
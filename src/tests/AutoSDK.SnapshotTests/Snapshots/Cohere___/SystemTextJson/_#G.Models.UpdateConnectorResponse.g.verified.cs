//HintName: G.Models.UpdateConnectorResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateConnectorResponse
    {
        /// <summary>
        /// A connector allows you to integrate data sources with the '/chat' endpoint to create grounded generations with citations to the data source.<br/>
        /// documents to help answer users.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connector")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Connector Connector { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateConnectorResponse" /> class.
        /// </summary>
        /// <param name="connector">
        /// A connector allows you to integrate data sources with the '/chat' endpoint to create grounded generations with citations to the data source.<br/>
        /// documents to help answer users.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UpdateConnectorResponse(
            global::G.Connector connector)
        {
            this.Connector = connector ?? throw new global::System.ArgumentNullException(nameof(connector));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateConnectorResponse" /> class.
        /// </summary>
        public UpdateConnectorResponse()
        {
        }
    }
}
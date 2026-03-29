//HintName: G.Models.OpenAPIUnpublishBotRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAPIUnpublishBotRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("connector_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ConnectorId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("unpublish_reason")]
        public string? UnpublishReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPIUnpublishBotRequest" /> class.
        /// </summary>
        /// <param name="connectorId"></param>
        /// <param name="unpublishReason"></param>
        public OpenAPIUnpublishBotRequest(
            string connectorId,
            string? unpublishReason)
        {
            this.ConnectorId = connectorId ?? throw new global::System.ArgumentNullException(nameof(connectorId));
            this.UnpublishReason = unpublishReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPIUnpublishBotRequest" /> class.
        /// </summary>
        public OpenAPIUnpublishBotRequest()
        {
        }
    }
}
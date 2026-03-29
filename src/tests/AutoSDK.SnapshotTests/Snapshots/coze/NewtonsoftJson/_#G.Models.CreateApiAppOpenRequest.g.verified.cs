//HintName: G.Models.CreateApiAppOpenRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateApiAppOpenRequest
    {
        /// <summary>
        /// 必填
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("app_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CreateApiAppOpenRequestAppType AppType { get; set; } = default!;

        /// <summary>
        /// app_type=connector 时必传
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("connector_id")]
        public string? ConnectorId { get; set; }

        /// <summary>
        /// 回调应用的名称， app_type=normal 时必传
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateApiAppOpenRequest" /> class.
        /// </summary>
        /// <param name="appType">
        /// 必填
        /// </param>
        /// <param name="connectorId">
        /// app_type=connector 时必传
        /// </param>
        /// <param name="name">
        /// 回调应用的名称， app_type=normal 时必传
        /// </param>
        public CreateApiAppOpenRequest(
            global::G.CreateApiAppOpenRequestAppType appType,
            string? connectorId,
            string? name)
        {
            this.AppType = appType;
            this.ConnectorId = connectorId;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateApiAppOpenRequest" /> class.
        /// </summary>
        public CreateApiAppOpenRequest()
        {
        }
    }
}
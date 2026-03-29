//HintName: G.Models.ApiAppOpenV2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiAppOpenV2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("app_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AppTypeOpen AppType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("connector_id")]
        public string? ConnectorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("verify_token", Required = global::Newtonsoft.Json.Required.Always)]
        public string VerifyToken { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiAppOpenV2" /> class.
        /// </summary>
        /// <param name="appType"></param>
        /// <param name="id"></param>
        /// <param name="verifyToken"></param>
        /// <param name="callbackUrl"></param>
        /// <param name="connectorId"></param>
        /// <param name="name"></param>
        public ApiAppOpenV2(
            global::G.AppTypeOpen appType,
            string id,
            string verifyToken,
            string? callbackUrl,
            string? connectorId,
            string? name)
        {
            this.AppType = appType;
            this.CallbackUrl = callbackUrl;
            this.ConnectorId = connectorId;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name;
            this.VerifyToken = verifyToken ?? throw new global::System.ArgumentNullException(nameof(verifyToken));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiAppOpenV2" /> class.
        /// </summary>
        public ApiAppOpenV2()
        {
        }
    }
}
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
        [global::System.Text.Json.Serialization.JsonPropertyName("app_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AppTypeOpenJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AppTypeOpen AppType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connector_id")]
        public string? ConnectorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verify_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VerifyToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
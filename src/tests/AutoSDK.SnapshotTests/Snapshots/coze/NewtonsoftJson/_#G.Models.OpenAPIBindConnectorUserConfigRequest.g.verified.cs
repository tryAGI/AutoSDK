//HintName: G.Models.OpenAPIBindConnectorUserConfigRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAPIBindConnectorUserConfigRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("configs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.UserConfig> Configs { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPIBindConnectorUserConfigRequest" /> class.
        /// </summary>
        /// <param name="configs"></param>
        /// <param name="userId"></param>
        public OpenAPIBindConnectorUserConfigRequest(
            global::System.Collections.Generic.IList<global::G.UserConfig> configs,
            string? userId)
        {
            this.Configs = configs ?? throw new global::System.ArgumentNullException(nameof(configs));
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPIBindConnectorUserConfigRequest" /> class.
        /// </summary>
        public OpenAPIBindConnectorUserConfigRequest()
        {
        }
    }
}
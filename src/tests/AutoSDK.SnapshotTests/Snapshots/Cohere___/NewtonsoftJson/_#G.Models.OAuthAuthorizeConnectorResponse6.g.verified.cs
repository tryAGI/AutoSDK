//HintName: G.Models.OAuthAuthorizeConnectorResponse6.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OAuthAuthorizeConnectorResponse6
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public string? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthAuthorizeConnectorResponse6" /> class.
        /// </summary>
        /// <param name="data"></param>
        public OAuthAuthorizeConnectorResponse6(
            string? data)
        {
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthAuthorizeConnectorResponse6" /> class.
        /// </summary>
        public OAuthAuthorizeConnectorResponse6()
        {
        }
    }
}
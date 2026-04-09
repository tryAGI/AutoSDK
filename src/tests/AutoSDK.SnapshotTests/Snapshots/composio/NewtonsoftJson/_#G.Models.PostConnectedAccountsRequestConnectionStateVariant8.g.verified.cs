//HintName: G.Models.PostConnectedAccountsRequestConnectionStateVariant8.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostConnectedAccountsRequestConnectionStateVariant8
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authScheme")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant8AuthSchemeJsonConverter))]
        public global::G.PostConnectedAccountsRequestConnectionStateVariant8AuthScheme AuthScheme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("val", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.PostConnectedAccountsRequestConnectionStateVariant8ValVariant1, global::G.PostConnectedAccountsRequestConnectionStateVariant8ValVariant2, global::G.PostConnectedAccountsRequestConnectionStateVariant8ValVariant3, global::G.PostConnectedAccountsRequestConnectionStateVariant8ValVariant4, global::G.PostConnectedAccountsRequestConnectionStateVariant8ValVariant5, global::G.PostConnectedAccountsRequestConnectionStateVariant8ValVariant6> Val { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsRequestConnectionStateVariant8" /> class.
        /// </summary>
        /// <param name="val"></param>
        /// <param name="authScheme"></param>
        public PostConnectedAccountsRequestConnectionStateVariant8(
            global::G.OneOf<global::G.PostConnectedAccountsRequestConnectionStateVariant8ValVariant1, global::G.PostConnectedAccountsRequestConnectionStateVariant8ValVariant2, global::G.PostConnectedAccountsRequestConnectionStateVariant8ValVariant3, global::G.PostConnectedAccountsRequestConnectionStateVariant8ValVariant4, global::G.PostConnectedAccountsRequestConnectionStateVariant8ValVariant5, global::G.PostConnectedAccountsRequestConnectionStateVariant8ValVariant6> val,
            global::G.PostConnectedAccountsRequestConnectionStateVariant8AuthScheme authScheme)
        {
            this.AuthScheme = authScheme;
            this.Val = val;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsRequestConnectionStateVariant8" /> class.
        /// </summary>
        public PostConnectedAccountsRequestConnectionStateVariant8()
        {
        }
    }
}
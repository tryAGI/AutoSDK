//HintName: G.Models.PostConnectedAccountsRequestConnectionStateVariant10.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostConnectedAccountsRequestConnectionStateVariant10
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authScheme")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant10AuthSchemeJsonConverter))]
        public global::G.PostConnectedAccountsRequestConnectionStateVariant10AuthScheme AuthScheme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("val", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.PostConnectedAccountsRequestConnectionStateVariant10ValVariant1, global::G.PostConnectedAccountsRequestConnectionStateVariant10ValVariant2, global::G.PostConnectedAccountsRequestConnectionStateVariant10ValVariant3, global::G.PostConnectedAccountsRequestConnectionStateVariant10ValVariant4, global::G.PostConnectedAccountsRequestConnectionStateVariant10ValVariant5, global::G.PostConnectedAccountsRequestConnectionStateVariant10ValVariant6> Val { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsRequestConnectionStateVariant10" /> class.
        /// </summary>
        /// <param name="val"></param>
        /// <param name="authScheme"></param>
        public PostConnectedAccountsRequestConnectionStateVariant10(
            global::G.OneOf<global::G.PostConnectedAccountsRequestConnectionStateVariant10ValVariant1, global::G.PostConnectedAccountsRequestConnectionStateVariant10ValVariant2, global::G.PostConnectedAccountsRequestConnectionStateVariant10ValVariant3, global::G.PostConnectedAccountsRequestConnectionStateVariant10ValVariant4, global::G.PostConnectedAccountsRequestConnectionStateVariant10ValVariant5, global::G.PostConnectedAccountsRequestConnectionStateVariant10ValVariant6> val,
            global::G.PostConnectedAccountsRequestConnectionStateVariant10AuthScheme authScheme)
        {
            this.AuthScheme = authScheme;
            this.Val = val;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsRequestConnectionStateVariant10" /> class.
        /// </summary>
        public PostConnectedAccountsRequestConnectionStateVariant10()
        {
        }
    }
}
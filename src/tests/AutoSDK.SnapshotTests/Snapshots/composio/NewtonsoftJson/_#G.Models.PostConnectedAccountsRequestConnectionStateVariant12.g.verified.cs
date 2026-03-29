//HintName: G.Models.PostConnectedAccountsRequestConnectionStateVariant12.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostConnectedAccountsRequestConnectionStateVariant12
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authScheme")]
        public global::G.PostConnectedAccountsRequestConnectionStateVariant12AuthScheme AuthScheme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("val", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.PostConnectedAccountsRequestConnectionStateVariant12ValVariant1, global::G.PostConnectedAccountsRequestConnectionStateVariant12ValVariant2, global::G.PostConnectedAccountsRequestConnectionStateVariant12ValVariant3, global::G.PostConnectedAccountsRequestConnectionStateVariant12ValVariant4, global::G.PostConnectedAccountsRequestConnectionStateVariant12ValVariant5, global::G.PostConnectedAccountsRequestConnectionStateVariant12ValVariant6> Val { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsRequestConnectionStateVariant12" /> class.
        /// </summary>
        /// <param name="val"></param>
        /// <param name="authScheme"></param>
        public PostConnectedAccountsRequestConnectionStateVariant12(
            global::G.OneOf<global::G.PostConnectedAccountsRequestConnectionStateVariant12ValVariant1, global::G.PostConnectedAccountsRequestConnectionStateVariant12ValVariant2, global::G.PostConnectedAccountsRequestConnectionStateVariant12ValVariant3, global::G.PostConnectedAccountsRequestConnectionStateVariant12ValVariant4, global::G.PostConnectedAccountsRequestConnectionStateVariant12ValVariant5, global::G.PostConnectedAccountsRequestConnectionStateVariant12ValVariant6> val,
            global::G.PostConnectedAccountsRequestConnectionStateVariant12AuthScheme authScheme)
        {
            this.AuthScheme = authScheme;
            this.Val = val;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsRequestConnectionStateVariant12" /> class.
        /// </summary>
        public PostConnectedAccountsRequestConnectionStateVariant12()
        {
        }
    }
}
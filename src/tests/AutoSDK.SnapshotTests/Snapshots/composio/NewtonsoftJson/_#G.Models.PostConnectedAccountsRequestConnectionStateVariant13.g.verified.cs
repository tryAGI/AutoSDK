//HintName: G.Models.PostConnectedAccountsRequestConnectionStateVariant13.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostConnectedAccountsRequestConnectionStateVariant13
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authScheme")]
        public global::G.PostConnectedAccountsRequestConnectionStateVariant13AuthScheme AuthScheme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("val", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.PostConnectedAccountsRequestConnectionStateVariant13ValVariant1, global::G.PostConnectedAccountsRequestConnectionStateVariant13ValVariant2, global::G.PostConnectedAccountsRequestConnectionStateVariant13ValVariant3, global::G.PostConnectedAccountsRequestConnectionStateVariant13ValVariant4, global::G.PostConnectedAccountsRequestConnectionStateVariant13ValVariant5, global::G.PostConnectedAccountsRequestConnectionStateVariant13ValVariant6> Val { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsRequestConnectionStateVariant13" /> class.
        /// </summary>
        /// <param name="val"></param>
        /// <param name="authScheme"></param>
        public PostConnectedAccountsRequestConnectionStateVariant13(
            global::G.OneOf<global::G.PostConnectedAccountsRequestConnectionStateVariant13ValVariant1, global::G.PostConnectedAccountsRequestConnectionStateVariant13ValVariant2, global::G.PostConnectedAccountsRequestConnectionStateVariant13ValVariant3, global::G.PostConnectedAccountsRequestConnectionStateVariant13ValVariant4, global::G.PostConnectedAccountsRequestConnectionStateVariant13ValVariant5, global::G.PostConnectedAccountsRequestConnectionStateVariant13ValVariant6> val,
            global::G.PostConnectedAccountsRequestConnectionStateVariant13AuthScheme authScheme)
        {
            this.AuthScheme = authScheme;
            this.Val = val;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsRequestConnectionStateVariant13" /> class.
        /// </summary>
        public PostConnectedAccountsRequestConnectionStateVariant13()
        {
        }
    }
}
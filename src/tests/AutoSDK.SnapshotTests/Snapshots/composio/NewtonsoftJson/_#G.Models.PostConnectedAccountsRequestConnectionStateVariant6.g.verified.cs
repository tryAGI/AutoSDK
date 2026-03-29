//HintName: G.Models.PostConnectedAccountsRequestConnectionStateVariant6.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostConnectedAccountsRequestConnectionStateVariant6
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authScheme")]
        public global::G.PostConnectedAccountsRequestConnectionStateVariant6AuthScheme AuthScheme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("val", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.PostConnectedAccountsRequestConnectionStateVariant6ValVariant1, global::G.PostConnectedAccountsRequestConnectionStateVariant6ValVariant2, global::G.PostConnectedAccountsRequestConnectionStateVariant6ValVariant3, global::G.PostConnectedAccountsRequestConnectionStateVariant6ValVariant4> Val { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsRequestConnectionStateVariant6" /> class.
        /// </summary>
        /// <param name="val"></param>
        /// <param name="authScheme"></param>
        public PostConnectedAccountsRequestConnectionStateVariant6(
            global::G.OneOf<global::G.PostConnectedAccountsRequestConnectionStateVariant6ValVariant1, global::G.PostConnectedAccountsRequestConnectionStateVariant6ValVariant2, global::G.PostConnectedAccountsRequestConnectionStateVariant6ValVariant3, global::G.PostConnectedAccountsRequestConnectionStateVariant6ValVariant4> val,
            global::G.PostConnectedAccountsRequestConnectionStateVariant6AuthScheme authScheme)
        {
            this.AuthScheme = authScheme;
            this.Val = val;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsRequestConnectionStateVariant6" /> class.
        /// </summary>
        public PostConnectedAccountsRequestConnectionStateVariant6()
        {
        }
    }
}
//HintName: G.Models.PostConnectedAccountsRequestConnectionStateVariant11.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostConnectedAccountsRequestConnectionStateVariant11
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authScheme")]
        public global::G.PostConnectedAccountsRequestConnectionStateVariant11AuthScheme AuthScheme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("val", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.PostConnectedAccountsRequestConnectionStateVariant11ValVariant1, global::G.PostConnectedAccountsRequestConnectionStateVariant11ValVariant2, global::G.PostConnectedAccountsRequestConnectionStateVariant11ValVariant3, global::G.PostConnectedAccountsRequestConnectionStateVariant11ValVariant4> Val { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsRequestConnectionStateVariant11" /> class.
        /// </summary>
        /// <param name="val"></param>
        /// <param name="authScheme"></param>
        public PostConnectedAccountsRequestConnectionStateVariant11(
            global::G.OneOf<global::G.PostConnectedAccountsRequestConnectionStateVariant11ValVariant1, global::G.PostConnectedAccountsRequestConnectionStateVariant11ValVariant2, global::G.PostConnectedAccountsRequestConnectionStateVariant11ValVariant3, global::G.PostConnectedAccountsRequestConnectionStateVariant11ValVariant4> val,
            global::G.PostConnectedAccountsRequestConnectionStateVariant11AuthScheme authScheme)
        {
            this.AuthScheme = authScheme;
            this.Val = val;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsRequestConnectionStateVariant11" /> class.
        /// </summary>
        public PostConnectedAccountsRequestConnectionStateVariant11()
        {
        }
    }
}
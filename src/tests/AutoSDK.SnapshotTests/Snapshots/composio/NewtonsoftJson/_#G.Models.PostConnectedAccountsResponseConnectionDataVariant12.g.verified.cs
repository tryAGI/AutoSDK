//HintName: G.Models.PostConnectedAccountsResponseConnectionDataVariant12.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostConnectedAccountsResponseConnectionDataVariant12
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authScheme")]
        public global::G.PostConnectedAccountsResponseConnectionDataVariant12AuthScheme AuthScheme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("val", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.PostConnectedAccountsResponseConnectionDataVariant12ValVariant1, global::G.PostConnectedAccountsResponseConnectionDataVariant12ValVariant2, global::G.PostConnectedAccountsResponseConnectionDataVariant12ValVariant3, global::G.PostConnectedAccountsResponseConnectionDataVariant12ValVariant4, global::G.PostConnectedAccountsResponseConnectionDataVariant12ValVariant5, global::G.PostConnectedAccountsResponseConnectionDataVariant12ValVariant6> Val { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsResponseConnectionDataVariant12" /> class.
        /// </summary>
        /// <param name="val"></param>
        /// <param name="authScheme"></param>
        public PostConnectedAccountsResponseConnectionDataVariant12(
            global::G.OneOf<global::G.PostConnectedAccountsResponseConnectionDataVariant12ValVariant1, global::G.PostConnectedAccountsResponseConnectionDataVariant12ValVariant2, global::G.PostConnectedAccountsResponseConnectionDataVariant12ValVariant3, global::G.PostConnectedAccountsResponseConnectionDataVariant12ValVariant4, global::G.PostConnectedAccountsResponseConnectionDataVariant12ValVariant5, global::G.PostConnectedAccountsResponseConnectionDataVariant12ValVariant6> val,
            global::G.PostConnectedAccountsResponseConnectionDataVariant12AuthScheme authScheme)
        {
            this.AuthScheme = authScheme;
            this.Val = val;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsResponseConnectionDataVariant12" /> class.
        /// </summary>
        public PostConnectedAccountsResponseConnectionDataVariant12()
        {
        }
    }
}
//HintName: G.Models.PostConnectedAccountsResponseConnectionDataVariant13.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostConnectedAccountsResponseConnectionDataVariant13
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authScheme")]
        public global::G.PostConnectedAccountsResponseConnectionDataVariant13AuthScheme AuthScheme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("val", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.PostConnectedAccountsResponseConnectionDataVariant13ValVariant1, global::G.PostConnectedAccountsResponseConnectionDataVariant13ValVariant2, global::G.PostConnectedAccountsResponseConnectionDataVariant13ValVariant3, global::G.PostConnectedAccountsResponseConnectionDataVariant13ValVariant4, global::G.PostConnectedAccountsResponseConnectionDataVariant13ValVariant5, global::G.PostConnectedAccountsResponseConnectionDataVariant13ValVariant6> Val { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsResponseConnectionDataVariant13" /> class.
        /// </summary>
        /// <param name="val"></param>
        /// <param name="authScheme"></param>
        public PostConnectedAccountsResponseConnectionDataVariant13(
            global::G.OneOf<global::G.PostConnectedAccountsResponseConnectionDataVariant13ValVariant1, global::G.PostConnectedAccountsResponseConnectionDataVariant13ValVariant2, global::G.PostConnectedAccountsResponseConnectionDataVariant13ValVariant3, global::G.PostConnectedAccountsResponseConnectionDataVariant13ValVariant4, global::G.PostConnectedAccountsResponseConnectionDataVariant13ValVariant5, global::G.PostConnectedAccountsResponseConnectionDataVariant13ValVariant6> val,
            global::G.PostConnectedAccountsResponseConnectionDataVariant13AuthScheme authScheme)
        {
            this.AuthScheme = authScheme;
            this.Val = val;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsResponseConnectionDataVariant13" /> class.
        /// </summary>
        public PostConnectedAccountsResponseConnectionDataVariant13()
        {
        }
    }
}
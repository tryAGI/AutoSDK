//HintName: G.Models.PostConnectedAccountsResponseConnectionDataVariant5.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostConnectedAccountsResponseConnectionDataVariant5
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authScheme")]
        public global::G.PostConnectedAccountsResponseConnectionDataVariant5AuthScheme AuthScheme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("val", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.PostConnectedAccountsResponseConnectionDataVariant5ValVariant1, global::G.PostConnectedAccountsResponseConnectionDataVariant5ValVariant2, global::G.PostConnectedAccountsResponseConnectionDataVariant5ValVariant3, global::G.PostConnectedAccountsResponseConnectionDataVariant5ValVariant4> Val { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsResponseConnectionDataVariant5" /> class.
        /// </summary>
        /// <param name="val"></param>
        /// <param name="authScheme"></param>
        public PostConnectedAccountsResponseConnectionDataVariant5(
            global::G.OneOf<global::G.PostConnectedAccountsResponseConnectionDataVariant5ValVariant1, global::G.PostConnectedAccountsResponseConnectionDataVariant5ValVariant2, global::G.PostConnectedAccountsResponseConnectionDataVariant5ValVariant3, global::G.PostConnectedAccountsResponseConnectionDataVariant5ValVariant4> val,
            global::G.PostConnectedAccountsResponseConnectionDataVariant5AuthScheme authScheme)
        {
            this.AuthScheme = authScheme;
            this.Val = val;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsResponseConnectionDataVariant5" /> class.
        /// </summary>
        public PostConnectedAccountsResponseConnectionDataVariant5()
        {
        }
    }
}
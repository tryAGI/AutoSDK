//HintName: G.Models.PostConnectedAccountsResponseConnectionDataVariant14.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostConnectedAccountsResponseConnectionDataVariant14
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authScheme")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant14AuthSchemeJsonConverter))]
        public global::G.PostConnectedAccountsResponseConnectionDataVariant14AuthScheme AuthScheme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("val", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.PostConnectedAccountsResponseConnectionDataVariant14ValVariant1, global::G.PostConnectedAccountsResponseConnectionDataVariant14ValVariant2, global::G.PostConnectedAccountsResponseConnectionDataVariant14ValVariant3, global::G.PostConnectedAccountsResponseConnectionDataVariant14ValVariant4, global::G.PostConnectedAccountsResponseConnectionDataVariant14ValVariant5, global::G.PostConnectedAccountsResponseConnectionDataVariant14ValVariant6> Val { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsResponseConnectionDataVariant14" /> class.
        /// </summary>
        /// <param name="val"></param>
        /// <param name="authScheme"></param>
        public PostConnectedAccountsResponseConnectionDataVariant14(
            global::G.OneOf<global::G.PostConnectedAccountsResponseConnectionDataVariant14ValVariant1, global::G.PostConnectedAccountsResponseConnectionDataVariant14ValVariant2, global::G.PostConnectedAccountsResponseConnectionDataVariant14ValVariant3, global::G.PostConnectedAccountsResponseConnectionDataVariant14ValVariant4, global::G.PostConnectedAccountsResponseConnectionDataVariant14ValVariant5, global::G.PostConnectedAccountsResponseConnectionDataVariant14ValVariant6> val,
            global::G.PostConnectedAccountsResponseConnectionDataVariant14AuthScheme authScheme)
        {
            this.AuthScheme = authScheme;
            this.Val = val;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsResponseConnectionDataVariant14" /> class.
        /// </summary>
        public PostConnectedAccountsResponseConnectionDataVariant14()
        {
        }
    }
}
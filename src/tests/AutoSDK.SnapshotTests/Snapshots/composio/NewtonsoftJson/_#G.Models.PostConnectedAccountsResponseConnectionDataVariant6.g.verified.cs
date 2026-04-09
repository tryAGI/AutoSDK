//HintName: G.Models.PostConnectedAccountsResponseConnectionDataVariant6.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostConnectedAccountsResponseConnectionDataVariant6
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authScheme")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant6AuthSchemeJsonConverter))]
        public global::G.PostConnectedAccountsResponseConnectionDataVariant6AuthScheme AuthScheme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("val", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.PostConnectedAccountsResponseConnectionDataVariant6ValVariant1, global::G.PostConnectedAccountsResponseConnectionDataVariant6ValVariant2, global::G.PostConnectedAccountsResponseConnectionDataVariant6ValVariant3, global::G.PostConnectedAccountsResponseConnectionDataVariant6ValVariant4> Val { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsResponseConnectionDataVariant6" /> class.
        /// </summary>
        /// <param name="val"></param>
        /// <param name="authScheme"></param>
        public PostConnectedAccountsResponseConnectionDataVariant6(
            global::G.OneOf<global::G.PostConnectedAccountsResponseConnectionDataVariant6ValVariant1, global::G.PostConnectedAccountsResponseConnectionDataVariant6ValVariant2, global::G.PostConnectedAccountsResponseConnectionDataVariant6ValVariant3, global::G.PostConnectedAccountsResponseConnectionDataVariant6ValVariant4> val,
            global::G.PostConnectedAccountsResponseConnectionDataVariant6AuthScheme authScheme)
        {
            this.AuthScheme = authScheme;
            this.Val = val;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsResponseConnectionDataVariant6" /> class.
        /// </summary>
        public PostConnectedAccountsResponseConnectionDataVariant6()
        {
        }
    }
}
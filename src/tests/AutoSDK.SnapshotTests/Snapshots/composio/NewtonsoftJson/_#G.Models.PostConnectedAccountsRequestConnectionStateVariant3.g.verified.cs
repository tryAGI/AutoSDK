//HintName: G.Models.PostConnectedAccountsRequestConnectionStateVariant3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostConnectedAccountsRequestConnectionStateVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authScheme")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant3AuthSchemeJsonConverter))]
        public global::G.PostConnectedAccountsRequestConnectionStateVariant3AuthScheme AuthScheme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("val", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.PostConnectedAccountsRequestConnectionStateVariant3ValVariant1, global::G.PostConnectedAccountsRequestConnectionStateVariant3ValVariant2, global::G.PostConnectedAccountsRequestConnectionStateVariant3ValVariant3, global::G.PostConnectedAccountsRequestConnectionStateVariant3ValVariant4> Val { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsRequestConnectionStateVariant3" /> class.
        /// </summary>
        /// <param name="val"></param>
        /// <param name="authScheme"></param>
        public PostConnectedAccountsRequestConnectionStateVariant3(
            global::G.OneOf<global::G.PostConnectedAccountsRequestConnectionStateVariant3ValVariant1, global::G.PostConnectedAccountsRequestConnectionStateVariant3ValVariant2, global::G.PostConnectedAccountsRequestConnectionStateVariant3ValVariant3, global::G.PostConnectedAccountsRequestConnectionStateVariant3ValVariant4> val,
            global::G.PostConnectedAccountsRequestConnectionStateVariant3AuthScheme authScheme)
        {
            this.AuthScheme = authScheme;
            this.Val = val;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsRequestConnectionStateVariant3" /> class.
        /// </summary>
        public PostConnectedAccountsRequestConnectionStateVariant3()
        {
        }
    }
}
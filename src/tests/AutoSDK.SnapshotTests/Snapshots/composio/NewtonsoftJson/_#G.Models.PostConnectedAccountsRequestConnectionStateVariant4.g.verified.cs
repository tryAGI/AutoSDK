//HintName: G.Models.PostConnectedAccountsRequestConnectionStateVariant4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostConnectedAccountsRequestConnectionStateVariant4
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authScheme")]
        public global::G.PostConnectedAccountsRequestConnectionStateVariant4AuthScheme AuthScheme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("val", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.PostConnectedAccountsRequestConnectionStateVariant4ValVariant1, global::G.PostConnectedAccountsRequestConnectionStateVariant4ValVariant2, global::G.PostConnectedAccountsRequestConnectionStateVariant4ValVariant3, global::G.PostConnectedAccountsRequestConnectionStateVariant4ValVariant4> Val { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsRequestConnectionStateVariant4" /> class.
        /// </summary>
        /// <param name="val"></param>
        /// <param name="authScheme"></param>
        public PostConnectedAccountsRequestConnectionStateVariant4(
            global::G.OneOf<global::G.PostConnectedAccountsRequestConnectionStateVariant4ValVariant1, global::G.PostConnectedAccountsRequestConnectionStateVariant4ValVariant2, global::G.PostConnectedAccountsRequestConnectionStateVariant4ValVariant3, global::G.PostConnectedAccountsRequestConnectionStateVariant4ValVariant4> val,
            global::G.PostConnectedAccountsRequestConnectionStateVariant4AuthScheme authScheme)
        {
            this.AuthScheme = authScheme;
            this.Val = val;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsRequestConnectionStateVariant4" /> class.
        /// </summary>
        public PostConnectedAccountsRequestConnectionStateVariant4()
        {
        }
    }
}
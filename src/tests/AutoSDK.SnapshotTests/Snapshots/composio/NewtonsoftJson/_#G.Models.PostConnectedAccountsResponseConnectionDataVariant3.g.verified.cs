//HintName: G.Models.PostConnectedAccountsResponseConnectionDataVariant3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostConnectedAccountsResponseConnectionDataVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authScheme")]
        public global::G.PostConnectedAccountsResponseConnectionDataVariant3AuthScheme AuthScheme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("val", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.PostConnectedAccountsResponseConnectionDataVariant3ValVariant1, global::G.PostConnectedAccountsResponseConnectionDataVariant3ValVariant2, global::G.PostConnectedAccountsResponseConnectionDataVariant3ValVariant3, global::G.PostConnectedAccountsResponseConnectionDataVariant3ValVariant4> Val { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsResponseConnectionDataVariant3" /> class.
        /// </summary>
        /// <param name="val"></param>
        /// <param name="authScheme"></param>
        public PostConnectedAccountsResponseConnectionDataVariant3(
            global::G.OneOf<global::G.PostConnectedAccountsResponseConnectionDataVariant3ValVariant1, global::G.PostConnectedAccountsResponseConnectionDataVariant3ValVariant2, global::G.PostConnectedAccountsResponseConnectionDataVariant3ValVariant3, global::G.PostConnectedAccountsResponseConnectionDataVariant3ValVariant4> val,
            global::G.PostConnectedAccountsResponseConnectionDataVariant3AuthScheme authScheme)
        {
            this.AuthScheme = authScheme;
            this.Val = val;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsResponseConnectionDataVariant3" /> class.
        /// </summary>
        public PostConnectedAccountsResponseConnectionDataVariant3()
        {
        }
    }
}
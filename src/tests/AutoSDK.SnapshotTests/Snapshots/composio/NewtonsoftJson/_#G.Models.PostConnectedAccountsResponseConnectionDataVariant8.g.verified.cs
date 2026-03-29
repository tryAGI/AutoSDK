//HintName: G.Models.PostConnectedAccountsResponseConnectionDataVariant8.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostConnectedAccountsResponseConnectionDataVariant8
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authScheme")]
        public global::G.PostConnectedAccountsResponseConnectionDataVariant8AuthScheme AuthScheme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("val", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.PostConnectedAccountsResponseConnectionDataVariant8ValVariant1, global::G.PostConnectedAccountsResponseConnectionDataVariant8ValVariant2, global::G.PostConnectedAccountsResponseConnectionDataVariant8ValVariant3, global::G.PostConnectedAccountsResponseConnectionDataVariant8ValVariant4, global::G.PostConnectedAccountsResponseConnectionDataVariant8ValVariant5, global::G.PostConnectedAccountsResponseConnectionDataVariant8ValVariant6> Val { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsResponseConnectionDataVariant8" /> class.
        /// </summary>
        /// <param name="val"></param>
        /// <param name="authScheme"></param>
        public PostConnectedAccountsResponseConnectionDataVariant8(
            global::G.OneOf<global::G.PostConnectedAccountsResponseConnectionDataVariant8ValVariant1, global::G.PostConnectedAccountsResponseConnectionDataVariant8ValVariant2, global::G.PostConnectedAccountsResponseConnectionDataVariant8ValVariant3, global::G.PostConnectedAccountsResponseConnectionDataVariant8ValVariant4, global::G.PostConnectedAccountsResponseConnectionDataVariant8ValVariant5, global::G.PostConnectedAccountsResponseConnectionDataVariant8ValVariant6> val,
            global::G.PostConnectedAccountsResponseConnectionDataVariant8AuthScheme authScheme)
        {
            this.AuthScheme = authScheme;
            this.Val = val;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsResponseConnectionDataVariant8" /> class.
        /// </summary>
        public PostConnectedAccountsResponseConnectionDataVariant8()
        {
        }
    }
}
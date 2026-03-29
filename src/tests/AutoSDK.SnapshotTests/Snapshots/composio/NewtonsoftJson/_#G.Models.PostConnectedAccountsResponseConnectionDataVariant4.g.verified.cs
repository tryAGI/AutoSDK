//HintName: G.Models.PostConnectedAccountsResponseConnectionDataVariant4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostConnectedAccountsResponseConnectionDataVariant4
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authScheme")]
        public global::G.PostConnectedAccountsResponseConnectionDataVariant4AuthScheme AuthScheme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("val", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.PostConnectedAccountsResponseConnectionDataVariant4ValVariant1, global::G.PostConnectedAccountsResponseConnectionDataVariant4ValVariant2, global::G.PostConnectedAccountsResponseConnectionDataVariant4ValVariant3, global::G.PostConnectedAccountsResponseConnectionDataVariant4ValVariant4> Val { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsResponseConnectionDataVariant4" /> class.
        /// </summary>
        /// <param name="val"></param>
        /// <param name="authScheme"></param>
        public PostConnectedAccountsResponseConnectionDataVariant4(
            global::G.OneOf<global::G.PostConnectedAccountsResponseConnectionDataVariant4ValVariant1, global::G.PostConnectedAccountsResponseConnectionDataVariant4ValVariant2, global::G.PostConnectedAccountsResponseConnectionDataVariant4ValVariant3, global::G.PostConnectedAccountsResponseConnectionDataVariant4ValVariant4> val,
            global::G.PostConnectedAccountsResponseConnectionDataVariant4AuthScheme authScheme)
        {
            this.AuthScheme = authScheme;
            this.Val = val;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsResponseConnectionDataVariant4" /> class.
        /// </summary>
        public PostConnectedAccountsResponseConnectionDataVariant4()
        {
        }
    }
}
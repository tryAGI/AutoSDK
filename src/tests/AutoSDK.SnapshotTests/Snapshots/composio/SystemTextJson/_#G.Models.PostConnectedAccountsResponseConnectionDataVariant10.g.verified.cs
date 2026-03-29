//HintName: G.Models.PostConnectedAccountsResponseConnectionDataVariant10.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostConnectedAccountsResponseConnectionDataVariant10
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authScheme")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant10AuthSchemeJsonConverter))]
        public global::G.PostConnectedAccountsResponseConnectionDataVariant10AuthScheme AuthScheme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("val")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.PostConnectedAccountsResponseConnectionDataVariant10ValVariant1, global::G.PostConnectedAccountsResponseConnectionDataVariant10ValVariant2, global::G.PostConnectedAccountsResponseConnectionDataVariant10ValVariant3, global::G.PostConnectedAccountsResponseConnectionDataVariant10ValVariant4, global::G.PostConnectedAccountsResponseConnectionDataVariant10ValVariant5, global::G.PostConnectedAccountsResponseConnectionDataVariant10ValVariant6>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OneOf<global::G.PostConnectedAccountsResponseConnectionDataVariant10ValVariant1, global::G.PostConnectedAccountsResponseConnectionDataVariant10ValVariant2, global::G.PostConnectedAccountsResponseConnectionDataVariant10ValVariant3, global::G.PostConnectedAccountsResponseConnectionDataVariant10ValVariant4, global::G.PostConnectedAccountsResponseConnectionDataVariant10ValVariant5, global::G.PostConnectedAccountsResponseConnectionDataVariant10ValVariant6> Val { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsResponseConnectionDataVariant10" /> class.
        /// </summary>
        /// <param name="val"></param>
        /// <param name="authScheme"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostConnectedAccountsResponseConnectionDataVariant10(
            global::G.OneOf<global::G.PostConnectedAccountsResponseConnectionDataVariant10ValVariant1, global::G.PostConnectedAccountsResponseConnectionDataVariant10ValVariant2, global::G.PostConnectedAccountsResponseConnectionDataVariant10ValVariant3, global::G.PostConnectedAccountsResponseConnectionDataVariant10ValVariant4, global::G.PostConnectedAccountsResponseConnectionDataVariant10ValVariant5, global::G.PostConnectedAccountsResponseConnectionDataVariant10ValVariant6> val,
            global::G.PostConnectedAccountsResponseConnectionDataVariant10AuthScheme authScheme)
        {
            this.AuthScheme = authScheme;
            this.Val = val;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsResponseConnectionDataVariant10" /> class.
        /// </summary>
        public PostConnectedAccountsResponseConnectionDataVariant10()
        {
        }
    }
}
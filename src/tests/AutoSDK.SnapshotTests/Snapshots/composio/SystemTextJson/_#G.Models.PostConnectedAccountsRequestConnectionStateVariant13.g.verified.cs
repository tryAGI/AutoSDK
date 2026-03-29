//HintName: G.Models.PostConnectedAccountsRequestConnectionStateVariant13.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostConnectedAccountsRequestConnectionStateVariant13
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authScheme")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant13AuthSchemeJsonConverter))]
        public global::G.PostConnectedAccountsRequestConnectionStateVariant13AuthScheme AuthScheme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("val")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.PostConnectedAccountsRequestConnectionStateVariant13ValVariant1, global::G.PostConnectedAccountsRequestConnectionStateVariant13ValVariant2, global::G.PostConnectedAccountsRequestConnectionStateVariant13ValVariant3, global::G.PostConnectedAccountsRequestConnectionStateVariant13ValVariant4, global::G.PostConnectedAccountsRequestConnectionStateVariant13ValVariant5, global::G.PostConnectedAccountsRequestConnectionStateVariant13ValVariant6>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OneOf<global::G.PostConnectedAccountsRequestConnectionStateVariant13ValVariant1, global::G.PostConnectedAccountsRequestConnectionStateVariant13ValVariant2, global::G.PostConnectedAccountsRequestConnectionStateVariant13ValVariant3, global::G.PostConnectedAccountsRequestConnectionStateVariant13ValVariant4, global::G.PostConnectedAccountsRequestConnectionStateVariant13ValVariant5, global::G.PostConnectedAccountsRequestConnectionStateVariant13ValVariant6> Val { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsRequestConnectionStateVariant13" /> class.
        /// </summary>
        /// <param name="val"></param>
        /// <param name="authScheme"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostConnectedAccountsRequestConnectionStateVariant13(
            global::G.OneOf<global::G.PostConnectedAccountsRequestConnectionStateVariant13ValVariant1, global::G.PostConnectedAccountsRequestConnectionStateVariant13ValVariant2, global::G.PostConnectedAccountsRequestConnectionStateVariant13ValVariant3, global::G.PostConnectedAccountsRequestConnectionStateVariant13ValVariant4, global::G.PostConnectedAccountsRequestConnectionStateVariant13ValVariant5, global::G.PostConnectedAccountsRequestConnectionStateVariant13ValVariant6> val,
            global::G.PostConnectedAccountsRequestConnectionStateVariant13AuthScheme authScheme)
        {
            this.AuthScheme = authScheme;
            this.Val = val;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsRequestConnectionStateVariant13" /> class.
        /// </summary>
        public PostConnectedAccountsRequestConnectionStateVariant13()
        {
        }
    }
}
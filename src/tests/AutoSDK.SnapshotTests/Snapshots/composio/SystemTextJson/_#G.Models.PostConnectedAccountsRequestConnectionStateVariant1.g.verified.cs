//HintName: G.Models.PostConnectedAccountsRequestConnectionStateVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostConnectedAccountsRequestConnectionStateVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authScheme")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant1AuthSchemeJsonConverter))]
        public global::G.PostConnectedAccountsRequestConnectionStateVariant1AuthScheme AuthScheme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("val")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.PostConnectedAccountsRequestConnectionStateVariant1ValVariant1, global::G.PostConnectedAccountsRequestConnectionStateVariant1ValVariant2, global::G.PostConnectedAccountsRequestConnectionStateVariant1ValVariant3, global::G.PostConnectedAccountsRequestConnectionStateVariant1ValVariant4, global::G.PostConnectedAccountsRequestConnectionStateVariant1ValVariant5, global::G.PostConnectedAccountsRequestConnectionStateVariant1ValVariant6>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OneOf<global::G.PostConnectedAccountsRequestConnectionStateVariant1ValVariant1, global::G.PostConnectedAccountsRequestConnectionStateVariant1ValVariant2, global::G.PostConnectedAccountsRequestConnectionStateVariant1ValVariant3, global::G.PostConnectedAccountsRequestConnectionStateVariant1ValVariant4, global::G.PostConnectedAccountsRequestConnectionStateVariant1ValVariant5, global::G.PostConnectedAccountsRequestConnectionStateVariant1ValVariant6> Val { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsRequestConnectionStateVariant1" /> class.
        /// </summary>
        /// <param name="val"></param>
        /// <param name="authScheme"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostConnectedAccountsRequestConnectionStateVariant1(
            global::G.OneOf<global::G.PostConnectedAccountsRequestConnectionStateVariant1ValVariant1, global::G.PostConnectedAccountsRequestConnectionStateVariant1ValVariant2, global::G.PostConnectedAccountsRequestConnectionStateVariant1ValVariant3, global::G.PostConnectedAccountsRequestConnectionStateVariant1ValVariant4, global::G.PostConnectedAccountsRequestConnectionStateVariant1ValVariant5, global::G.PostConnectedAccountsRequestConnectionStateVariant1ValVariant6> val,
            global::G.PostConnectedAccountsRequestConnectionStateVariant1AuthScheme authScheme)
        {
            this.AuthScheme = authScheme;
            this.Val = val;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsRequestConnectionStateVariant1" /> class.
        /// </summary>
        public PostConnectedAccountsRequestConnectionStateVariant1()
        {
        }
    }
}
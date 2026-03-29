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
        [global::System.Text.Json.Serialization.JsonPropertyName("authScheme")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant4AuthSchemeJsonConverter))]
        public global::G.PostConnectedAccountsRequestConnectionStateVariant4AuthScheme AuthScheme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("val")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.PostConnectedAccountsRequestConnectionStateVariant4ValVariant1, global::G.PostConnectedAccountsRequestConnectionStateVariant4ValVariant2, global::G.PostConnectedAccountsRequestConnectionStateVariant4ValVariant3, global::G.PostConnectedAccountsRequestConnectionStateVariant4ValVariant4>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OneOf<global::G.PostConnectedAccountsRequestConnectionStateVariant4ValVariant1, global::G.PostConnectedAccountsRequestConnectionStateVariant4ValVariant2, global::G.PostConnectedAccountsRequestConnectionStateVariant4ValVariant3, global::G.PostConnectedAccountsRequestConnectionStateVariant4ValVariant4> Val { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsRequestConnectionStateVariant4" /> class.
        /// </summary>
        /// <param name="val"></param>
        /// <param name="authScheme"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
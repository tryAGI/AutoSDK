//HintName: G.Models.GetConnectedAccountsResponseItemStateVariant9.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConnectedAccountsResponseItemStateVariant9
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authScheme")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant9AuthSchemeJsonConverter))]
        public global::G.GetConnectedAccountsResponseItemStateVariant9AuthScheme AuthScheme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("val")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.GetConnectedAccountsResponseItemStateVariant9ValVariant1, global::G.GetConnectedAccountsResponseItemStateVariant9ValVariant2, global::G.GetConnectedAccountsResponseItemStateVariant9ValVariant3, global::G.GetConnectedAccountsResponseItemStateVariant9ValVariant4, global::G.GetConnectedAccountsResponseItemStateVariant9ValVariant5, global::G.GetConnectedAccountsResponseItemStateVariant9ValVariant6>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OneOf<global::G.GetConnectedAccountsResponseItemStateVariant9ValVariant1, global::G.GetConnectedAccountsResponseItemStateVariant9ValVariant2, global::G.GetConnectedAccountsResponseItemStateVariant9ValVariant3, global::G.GetConnectedAccountsResponseItemStateVariant9ValVariant4, global::G.GetConnectedAccountsResponseItemStateVariant9ValVariant5, global::G.GetConnectedAccountsResponseItemStateVariant9ValVariant6> Val { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsResponseItemStateVariant9" /> class.
        /// </summary>
        /// <param name="val"></param>
        /// <param name="authScheme"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetConnectedAccountsResponseItemStateVariant9(
            global::G.OneOf<global::G.GetConnectedAccountsResponseItemStateVariant9ValVariant1, global::G.GetConnectedAccountsResponseItemStateVariant9ValVariant2, global::G.GetConnectedAccountsResponseItemStateVariant9ValVariant3, global::G.GetConnectedAccountsResponseItemStateVariant9ValVariant4, global::G.GetConnectedAccountsResponseItemStateVariant9ValVariant5, global::G.GetConnectedAccountsResponseItemStateVariant9ValVariant6> val,
            global::G.GetConnectedAccountsResponseItemStateVariant9AuthScheme authScheme)
        {
            this.AuthScheme = authScheme;
            this.Val = val;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsResponseItemStateVariant9" /> class.
        /// </summary>
        public GetConnectedAccountsResponseItemStateVariant9()
        {
        }
    }
}
//HintName: G.Models.GetConnectedAccountsResponseItemStateVariant6.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConnectedAccountsResponseItemStateVariant6
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authScheme")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant6AuthSchemeJsonConverter))]
        public global::G.GetConnectedAccountsResponseItemStateVariant6AuthScheme AuthScheme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("val")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.GetConnectedAccountsResponseItemStateVariant6ValVariant1, global::G.GetConnectedAccountsResponseItemStateVariant6ValVariant2, global::G.GetConnectedAccountsResponseItemStateVariant6ValVariant3, global::G.GetConnectedAccountsResponseItemStateVariant6ValVariant4>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OneOf<global::G.GetConnectedAccountsResponseItemStateVariant6ValVariant1, global::G.GetConnectedAccountsResponseItemStateVariant6ValVariant2, global::G.GetConnectedAccountsResponseItemStateVariant6ValVariant3, global::G.GetConnectedAccountsResponseItemStateVariant6ValVariant4> Val { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsResponseItemStateVariant6" /> class.
        /// </summary>
        /// <param name="val"></param>
        /// <param name="authScheme"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetConnectedAccountsResponseItemStateVariant6(
            global::G.OneOf<global::G.GetConnectedAccountsResponseItemStateVariant6ValVariant1, global::G.GetConnectedAccountsResponseItemStateVariant6ValVariant2, global::G.GetConnectedAccountsResponseItemStateVariant6ValVariant3, global::G.GetConnectedAccountsResponseItemStateVariant6ValVariant4> val,
            global::G.GetConnectedAccountsResponseItemStateVariant6AuthScheme authScheme)
        {
            this.AuthScheme = authScheme;
            this.Val = val;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsResponseItemStateVariant6" /> class.
        /// </summary>
        public GetConnectedAccountsResponseItemStateVariant6()
        {
        }
    }
}
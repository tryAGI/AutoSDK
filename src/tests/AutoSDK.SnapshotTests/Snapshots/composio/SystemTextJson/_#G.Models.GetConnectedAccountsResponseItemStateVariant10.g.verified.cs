//HintName: G.Models.GetConnectedAccountsResponseItemStateVariant10.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConnectedAccountsResponseItemStateVariant10
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authScheme")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant10AuthSchemeJsonConverter))]
        public global::G.GetConnectedAccountsResponseItemStateVariant10AuthScheme AuthScheme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("val")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.GetConnectedAccountsResponseItemStateVariant10ValVariant1, global::G.GetConnectedAccountsResponseItemStateVariant10ValVariant2, global::G.GetConnectedAccountsResponseItemStateVariant10ValVariant3, global::G.GetConnectedAccountsResponseItemStateVariant10ValVariant4, global::G.GetConnectedAccountsResponseItemStateVariant10ValVariant5, global::G.GetConnectedAccountsResponseItemStateVariant10ValVariant6>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OneOf<global::G.GetConnectedAccountsResponseItemStateVariant10ValVariant1, global::G.GetConnectedAccountsResponseItemStateVariant10ValVariant2, global::G.GetConnectedAccountsResponseItemStateVariant10ValVariant3, global::G.GetConnectedAccountsResponseItemStateVariant10ValVariant4, global::G.GetConnectedAccountsResponseItemStateVariant10ValVariant5, global::G.GetConnectedAccountsResponseItemStateVariant10ValVariant6> Val { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsResponseItemStateVariant10" /> class.
        /// </summary>
        /// <param name="val"></param>
        /// <param name="authScheme"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetConnectedAccountsResponseItemStateVariant10(
            global::G.OneOf<global::G.GetConnectedAccountsResponseItemStateVariant10ValVariant1, global::G.GetConnectedAccountsResponseItemStateVariant10ValVariant2, global::G.GetConnectedAccountsResponseItemStateVariant10ValVariant3, global::G.GetConnectedAccountsResponseItemStateVariant10ValVariant4, global::G.GetConnectedAccountsResponseItemStateVariant10ValVariant5, global::G.GetConnectedAccountsResponseItemStateVariant10ValVariant6> val,
            global::G.GetConnectedAccountsResponseItemStateVariant10AuthScheme authScheme)
        {
            this.AuthScheme = authScheme;
            this.Val = val;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsResponseItemStateVariant10" /> class.
        /// </summary>
        public GetConnectedAccountsResponseItemStateVariant10()
        {
        }
    }
}
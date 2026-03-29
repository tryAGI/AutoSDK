//HintName: G.Models.GetConnectedAccountsByNanoidResponseStateVariant12.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConnectedAccountsByNanoidResponseStateVariant12
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authScheme")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant12AuthSchemeJsonConverter))]
        public global::G.GetConnectedAccountsByNanoidResponseStateVariant12AuthScheme AuthScheme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("val")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant1, global::G.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant2, global::G.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant3, global::G.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant4, global::G.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant5, global::G.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant6>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OneOf<global::G.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant1, global::G.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant2, global::G.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant3, global::G.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant4, global::G.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant5, global::G.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant6> Val { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsByNanoidResponseStateVariant12" /> class.
        /// </summary>
        /// <param name="val"></param>
        /// <param name="authScheme"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetConnectedAccountsByNanoidResponseStateVariant12(
            global::G.OneOf<global::G.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant1, global::G.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant2, global::G.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant3, global::G.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant4, global::G.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant5, global::G.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant6> val,
            global::G.GetConnectedAccountsByNanoidResponseStateVariant12AuthScheme authScheme)
        {
            this.AuthScheme = authScheme;
            this.Val = val;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsByNanoidResponseStateVariant12" /> class.
        /// </summary>
        public GetConnectedAccountsByNanoidResponseStateVariant12()
        {
        }
    }
}
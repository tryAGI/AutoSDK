//HintName: G.Models.GetConnectedAccountsByNanoidResponseStateVariant5.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConnectedAccountsByNanoidResponseStateVariant5
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authScheme")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant5AuthSchemeJsonConverter))]
        public global::G.GetConnectedAccountsByNanoidResponseStateVariant5AuthScheme AuthScheme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("val")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.GetConnectedAccountsByNanoidResponseStateVariant5ValVariant1, global::G.GetConnectedAccountsByNanoidResponseStateVariant5ValVariant2, global::G.GetConnectedAccountsByNanoidResponseStateVariant5ValVariant3, global::G.GetConnectedAccountsByNanoidResponseStateVariant5ValVariant4>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OneOf<global::G.GetConnectedAccountsByNanoidResponseStateVariant5ValVariant1, global::G.GetConnectedAccountsByNanoidResponseStateVariant5ValVariant2, global::G.GetConnectedAccountsByNanoidResponseStateVariant5ValVariant3, global::G.GetConnectedAccountsByNanoidResponseStateVariant5ValVariant4> Val { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsByNanoidResponseStateVariant5" /> class.
        /// </summary>
        /// <param name="val"></param>
        /// <param name="authScheme"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetConnectedAccountsByNanoidResponseStateVariant5(
            global::G.OneOf<global::G.GetConnectedAccountsByNanoidResponseStateVariant5ValVariant1, global::G.GetConnectedAccountsByNanoidResponseStateVariant5ValVariant2, global::G.GetConnectedAccountsByNanoidResponseStateVariant5ValVariant3, global::G.GetConnectedAccountsByNanoidResponseStateVariant5ValVariant4> val,
            global::G.GetConnectedAccountsByNanoidResponseStateVariant5AuthScheme authScheme)
        {
            this.AuthScheme = authScheme;
            this.Val = val;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsByNanoidResponseStateVariant5" /> class.
        /// </summary>
        public GetConnectedAccountsByNanoidResponseStateVariant5()
        {
        }
    }
}
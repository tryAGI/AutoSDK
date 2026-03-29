//HintName: G.Models.GetConnectedAccountsByNanoidResponseStateVariant6.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConnectedAccountsByNanoidResponseStateVariant6
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authScheme")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant6AuthSchemeJsonConverter))]
        public global::G.GetConnectedAccountsByNanoidResponseStateVariant6AuthScheme AuthScheme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("val")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant1, global::G.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant2, global::G.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant3, global::G.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant4>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OneOf<global::G.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant1, global::G.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant2, global::G.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant3, global::G.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant4> Val { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsByNanoidResponseStateVariant6" /> class.
        /// </summary>
        /// <param name="val"></param>
        /// <param name="authScheme"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetConnectedAccountsByNanoidResponseStateVariant6(
            global::G.OneOf<global::G.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant1, global::G.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant2, global::G.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant3, global::G.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant4> val,
            global::G.GetConnectedAccountsByNanoidResponseStateVariant6AuthScheme authScheme)
        {
            this.AuthScheme = authScheme;
            this.Val = val;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsByNanoidResponseStateVariant6" /> class.
        /// </summary>
        public GetConnectedAccountsByNanoidResponseStateVariant6()
        {
        }
    }
}
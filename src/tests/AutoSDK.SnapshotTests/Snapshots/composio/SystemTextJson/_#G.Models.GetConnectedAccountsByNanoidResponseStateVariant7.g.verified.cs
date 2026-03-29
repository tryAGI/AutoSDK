//HintName: G.Models.GetConnectedAccountsByNanoidResponseStateVariant7.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConnectedAccountsByNanoidResponseStateVariant7
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authScheme")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant7AuthSchemeJsonConverter))]
        public global::G.GetConnectedAccountsByNanoidResponseStateVariant7AuthScheme AuthScheme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("val")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant1, global::G.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant2, global::G.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant3, global::G.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant4, global::G.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant5, global::G.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant6>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OneOf<global::G.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant1, global::G.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant2, global::G.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant3, global::G.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant4, global::G.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant5, global::G.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant6> Val { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsByNanoidResponseStateVariant7" /> class.
        /// </summary>
        /// <param name="val"></param>
        /// <param name="authScheme"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetConnectedAccountsByNanoidResponseStateVariant7(
            global::G.OneOf<global::G.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant1, global::G.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant2, global::G.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant3, global::G.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant4, global::G.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant5, global::G.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant6> val,
            global::G.GetConnectedAccountsByNanoidResponseStateVariant7AuthScheme authScheme)
        {
            this.AuthScheme = authScheme;
            this.Val = val;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsByNanoidResponseStateVariant7" /> class.
        /// </summary>
        public GetConnectedAccountsByNanoidResponseStateVariant7()
        {
        }
    }
}
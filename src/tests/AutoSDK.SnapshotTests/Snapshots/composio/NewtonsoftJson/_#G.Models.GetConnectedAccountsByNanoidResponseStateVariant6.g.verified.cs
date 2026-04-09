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
        [global::Newtonsoft.Json.JsonProperty("authScheme")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant6AuthSchemeJsonConverter))]
        public global::G.GetConnectedAccountsByNanoidResponseStateVariant6AuthScheme AuthScheme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("val", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant1, global::G.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant2, global::G.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant3, global::G.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant4> Val { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsByNanoidResponseStateVariant6" /> class.
        /// </summary>
        /// <param name="val"></param>
        /// <param name="authScheme"></param>
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
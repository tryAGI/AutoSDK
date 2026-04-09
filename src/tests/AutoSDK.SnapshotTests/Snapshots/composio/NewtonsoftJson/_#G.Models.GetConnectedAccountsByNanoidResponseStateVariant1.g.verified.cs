//HintName: G.Models.GetConnectedAccountsByNanoidResponseStateVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConnectedAccountsByNanoidResponseStateVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authScheme")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant1AuthSchemeJsonConverter))]
        public global::G.GetConnectedAccountsByNanoidResponseStateVariant1AuthScheme AuthScheme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("val", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant1, global::G.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant2, global::G.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant3, global::G.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant4, global::G.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant5, global::G.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant6> Val { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsByNanoidResponseStateVariant1" /> class.
        /// </summary>
        /// <param name="val"></param>
        /// <param name="authScheme"></param>
        public GetConnectedAccountsByNanoidResponseStateVariant1(
            global::G.OneOf<global::G.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant1, global::G.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant2, global::G.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant3, global::G.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant4, global::G.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant5, global::G.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant6> val,
            global::G.GetConnectedAccountsByNanoidResponseStateVariant1AuthScheme authScheme)
        {
            this.AuthScheme = authScheme;
            this.Val = val;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsByNanoidResponseStateVariant1" /> class.
        /// </summary>
        public GetConnectedAccountsByNanoidResponseStateVariant1()
        {
        }
    }
}
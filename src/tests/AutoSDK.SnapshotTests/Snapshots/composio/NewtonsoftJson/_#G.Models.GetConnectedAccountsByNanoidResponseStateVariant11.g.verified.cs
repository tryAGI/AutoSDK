//HintName: G.Models.GetConnectedAccountsByNanoidResponseStateVariant11.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConnectedAccountsByNanoidResponseStateVariant11
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authScheme")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant11AuthSchemeJsonConverter))]
        public global::G.GetConnectedAccountsByNanoidResponseStateVariant11AuthScheme AuthScheme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("val", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.GetConnectedAccountsByNanoidResponseStateVariant11ValVariant1, global::G.GetConnectedAccountsByNanoidResponseStateVariant11ValVariant2, global::G.GetConnectedAccountsByNanoidResponseStateVariant11ValVariant3, global::G.GetConnectedAccountsByNanoidResponseStateVariant11ValVariant4> Val { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsByNanoidResponseStateVariant11" /> class.
        /// </summary>
        /// <param name="val"></param>
        /// <param name="authScheme"></param>
        public GetConnectedAccountsByNanoidResponseStateVariant11(
            global::G.OneOf<global::G.GetConnectedAccountsByNanoidResponseStateVariant11ValVariant1, global::G.GetConnectedAccountsByNanoidResponseStateVariant11ValVariant2, global::G.GetConnectedAccountsByNanoidResponseStateVariant11ValVariant3, global::G.GetConnectedAccountsByNanoidResponseStateVariant11ValVariant4> val,
            global::G.GetConnectedAccountsByNanoidResponseStateVariant11AuthScheme authScheme)
        {
            this.AuthScheme = authScheme;
            this.Val = val;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsByNanoidResponseStateVariant11" /> class.
        /// </summary>
        public GetConnectedAccountsByNanoidResponseStateVariant11()
        {
        }
    }
}
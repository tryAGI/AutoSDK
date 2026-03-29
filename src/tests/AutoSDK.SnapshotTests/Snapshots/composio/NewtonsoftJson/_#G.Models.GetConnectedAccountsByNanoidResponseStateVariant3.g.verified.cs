//HintName: G.Models.GetConnectedAccountsByNanoidResponseStateVariant3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConnectedAccountsByNanoidResponseStateVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authScheme")]
        public global::G.GetConnectedAccountsByNanoidResponseStateVariant3AuthScheme AuthScheme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("val", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.GetConnectedAccountsByNanoidResponseStateVariant3ValVariant1, global::G.GetConnectedAccountsByNanoidResponseStateVariant3ValVariant2, global::G.GetConnectedAccountsByNanoidResponseStateVariant3ValVariant3, global::G.GetConnectedAccountsByNanoidResponseStateVariant3ValVariant4> Val { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsByNanoidResponseStateVariant3" /> class.
        /// </summary>
        /// <param name="val"></param>
        /// <param name="authScheme"></param>
        public GetConnectedAccountsByNanoidResponseStateVariant3(
            global::G.OneOf<global::G.GetConnectedAccountsByNanoidResponseStateVariant3ValVariant1, global::G.GetConnectedAccountsByNanoidResponseStateVariant3ValVariant2, global::G.GetConnectedAccountsByNanoidResponseStateVariant3ValVariant3, global::G.GetConnectedAccountsByNanoidResponseStateVariant3ValVariant4> val,
            global::G.GetConnectedAccountsByNanoidResponseStateVariant3AuthScheme authScheme)
        {
            this.AuthScheme = authScheme;
            this.Val = val;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsByNanoidResponseStateVariant3" /> class.
        /// </summary>
        public GetConnectedAccountsByNanoidResponseStateVariant3()
        {
        }
    }
}
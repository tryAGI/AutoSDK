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
        [global::Newtonsoft.Json.JsonProperty("authScheme")]
        public global::G.GetConnectedAccountsByNanoidResponseStateVariant7AuthScheme AuthScheme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("val", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant1, global::G.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant2, global::G.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant3, global::G.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant4, global::G.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant5, global::G.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant6> Val { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsByNanoidResponseStateVariant7" /> class.
        /// </summary>
        /// <param name="val"></param>
        /// <param name="authScheme"></param>
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
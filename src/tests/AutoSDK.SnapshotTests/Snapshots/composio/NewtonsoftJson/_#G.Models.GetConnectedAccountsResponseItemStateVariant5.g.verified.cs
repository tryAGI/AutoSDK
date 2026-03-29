//HintName: G.Models.GetConnectedAccountsResponseItemStateVariant5.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConnectedAccountsResponseItemStateVariant5
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authScheme")]
        public global::G.GetConnectedAccountsResponseItemStateVariant5AuthScheme AuthScheme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("val", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.GetConnectedAccountsResponseItemStateVariant5ValVariant1, global::G.GetConnectedAccountsResponseItemStateVariant5ValVariant2, global::G.GetConnectedAccountsResponseItemStateVariant5ValVariant3, global::G.GetConnectedAccountsResponseItemStateVariant5ValVariant4> Val { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsResponseItemStateVariant5" /> class.
        /// </summary>
        /// <param name="val"></param>
        /// <param name="authScheme"></param>
        public GetConnectedAccountsResponseItemStateVariant5(
            global::G.OneOf<global::G.GetConnectedAccountsResponseItemStateVariant5ValVariant1, global::G.GetConnectedAccountsResponseItemStateVariant5ValVariant2, global::G.GetConnectedAccountsResponseItemStateVariant5ValVariant3, global::G.GetConnectedAccountsResponseItemStateVariant5ValVariant4> val,
            global::G.GetConnectedAccountsResponseItemStateVariant5AuthScheme authScheme)
        {
            this.AuthScheme = authScheme;
            this.Val = val;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsResponseItemStateVariant5" /> class.
        /// </summary>
        public GetConnectedAccountsResponseItemStateVariant5()
        {
        }
    }
}
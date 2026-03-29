//HintName: G.Models.GetConnectedAccountsResponseItemStateVariant10.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConnectedAccountsResponseItemStateVariant10
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authScheme")]
        public global::G.GetConnectedAccountsResponseItemStateVariant10AuthScheme AuthScheme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("val", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.GetConnectedAccountsResponseItemStateVariant10ValVariant1, global::G.GetConnectedAccountsResponseItemStateVariant10ValVariant2, global::G.GetConnectedAccountsResponseItemStateVariant10ValVariant3, global::G.GetConnectedAccountsResponseItemStateVariant10ValVariant4, global::G.GetConnectedAccountsResponseItemStateVariant10ValVariant5, global::G.GetConnectedAccountsResponseItemStateVariant10ValVariant6> Val { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsResponseItemStateVariant10" /> class.
        /// </summary>
        /// <param name="val"></param>
        /// <param name="authScheme"></param>
        public GetConnectedAccountsResponseItemStateVariant10(
            global::G.OneOf<global::G.GetConnectedAccountsResponseItemStateVariant10ValVariant1, global::G.GetConnectedAccountsResponseItemStateVariant10ValVariant2, global::G.GetConnectedAccountsResponseItemStateVariant10ValVariant3, global::G.GetConnectedAccountsResponseItemStateVariant10ValVariant4, global::G.GetConnectedAccountsResponseItemStateVariant10ValVariant5, global::G.GetConnectedAccountsResponseItemStateVariant10ValVariant6> val,
            global::G.GetConnectedAccountsResponseItemStateVariant10AuthScheme authScheme)
        {
            this.AuthScheme = authScheme;
            this.Val = val;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsResponseItemStateVariant10" /> class.
        /// </summary>
        public GetConnectedAccountsResponseItemStateVariant10()
        {
        }
    }
}
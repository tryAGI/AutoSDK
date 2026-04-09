//HintName: G.Models.GetConnectedAccountsResponseItemStateVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConnectedAccountsResponseItemStateVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authScheme")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant1AuthSchemeJsonConverter))]
        public global::G.GetConnectedAccountsResponseItemStateVariant1AuthScheme AuthScheme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("val", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.GetConnectedAccountsResponseItemStateVariant1ValVariant1, global::G.GetConnectedAccountsResponseItemStateVariant1ValVariant2, global::G.GetConnectedAccountsResponseItemStateVariant1ValVariant3, global::G.GetConnectedAccountsResponseItemStateVariant1ValVariant4, global::G.GetConnectedAccountsResponseItemStateVariant1ValVariant5, global::G.GetConnectedAccountsResponseItemStateVariant1ValVariant6> Val { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsResponseItemStateVariant1" /> class.
        /// </summary>
        /// <param name="val"></param>
        /// <param name="authScheme"></param>
        public GetConnectedAccountsResponseItemStateVariant1(
            global::G.OneOf<global::G.GetConnectedAccountsResponseItemStateVariant1ValVariant1, global::G.GetConnectedAccountsResponseItemStateVariant1ValVariant2, global::G.GetConnectedAccountsResponseItemStateVariant1ValVariant3, global::G.GetConnectedAccountsResponseItemStateVariant1ValVariant4, global::G.GetConnectedAccountsResponseItemStateVariant1ValVariant5, global::G.GetConnectedAccountsResponseItemStateVariant1ValVariant6> val,
            global::G.GetConnectedAccountsResponseItemStateVariant1AuthScheme authScheme)
        {
            this.AuthScheme = authScheme;
            this.Val = val;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsResponseItemStateVariant1" /> class.
        /// </summary>
        public GetConnectedAccountsResponseItemStateVariant1()
        {
        }
    }
}
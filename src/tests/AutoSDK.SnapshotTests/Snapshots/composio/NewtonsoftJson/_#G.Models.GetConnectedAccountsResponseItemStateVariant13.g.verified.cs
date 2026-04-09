//HintName: G.Models.GetConnectedAccountsResponseItemStateVariant13.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConnectedAccountsResponseItemStateVariant13
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authScheme")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant13AuthSchemeJsonConverter))]
        public global::G.GetConnectedAccountsResponseItemStateVariant13AuthScheme AuthScheme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("val", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.GetConnectedAccountsResponseItemStateVariant13ValVariant1, global::G.GetConnectedAccountsResponseItemStateVariant13ValVariant2, global::G.GetConnectedAccountsResponseItemStateVariant13ValVariant3, global::G.GetConnectedAccountsResponseItemStateVariant13ValVariant4, global::G.GetConnectedAccountsResponseItemStateVariant13ValVariant5, global::G.GetConnectedAccountsResponseItemStateVariant13ValVariant6> Val { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsResponseItemStateVariant13" /> class.
        /// </summary>
        /// <param name="val"></param>
        /// <param name="authScheme"></param>
        public GetConnectedAccountsResponseItemStateVariant13(
            global::G.OneOf<global::G.GetConnectedAccountsResponseItemStateVariant13ValVariant1, global::G.GetConnectedAccountsResponseItemStateVariant13ValVariant2, global::G.GetConnectedAccountsResponseItemStateVariant13ValVariant3, global::G.GetConnectedAccountsResponseItemStateVariant13ValVariant4, global::G.GetConnectedAccountsResponseItemStateVariant13ValVariant5, global::G.GetConnectedAccountsResponseItemStateVariant13ValVariant6> val,
            global::G.GetConnectedAccountsResponseItemStateVariant13AuthScheme authScheme)
        {
            this.AuthScheme = authScheme;
            this.Val = val;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsResponseItemStateVariant13" /> class.
        /// </summary>
        public GetConnectedAccountsResponseItemStateVariant13()
        {
        }
    }
}
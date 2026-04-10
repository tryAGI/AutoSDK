//HintName: G.Models.GetConnectedAccountsResponseItemStateVariant11.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConnectedAccountsResponseItemStateVariant11
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authScheme")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant11AuthSchemeJsonConverter))]
        public global::G.GetConnectedAccountsResponseItemStateVariant11AuthScheme AuthScheme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("val", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.GetConnectedAccountsResponseItemStateVariant11ValVariant1, global::G.GetConnectedAccountsResponseItemStateVariant11ValVariant2, global::G.GetConnectedAccountsResponseItemStateVariant11ValVariant3, global::G.GetConnectedAccountsResponseItemStateVariant11ValVariant4> Val { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsResponseItemStateVariant11" /> class.
        /// </summary>
        /// <param name="val"></param>
        /// <param name="authScheme"></param>
        public GetConnectedAccountsResponseItemStateVariant11(
            global::G.OneOf<global::G.GetConnectedAccountsResponseItemStateVariant11ValVariant1, global::G.GetConnectedAccountsResponseItemStateVariant11ValVariant2, global::G.GetConnectedAccountsResponseItemStateVariant11ValVariant3, global::G.GetConnectedAccountsResponseItemStateVariant11ValVariant4> val,
            global::G.GetConnectedAccountsResponseItemStateVariant11AuthScheme authScheme)
        {
            this.AuthScheme = authScheme;
            this.Val = val;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsResponseItemStateVariant11" /> class.
        /// </summary>
        public GetConnectedAccountsResponseItemStateVariant11()
        {
        }
    }
}
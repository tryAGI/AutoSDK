//HintName: G.Models.GetConnectedAccountsResponseItemStateVariant3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConnectedAccountsResponseItemStateVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authScheme")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant3AuthSchemeJsonConverter))]
        public global::G.GetConnectedAccountsResponseItemStateVariant3AuthScheme AuthScheme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("val", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.GetConnectedAccountsResponseItemStateVariant3ValVariant1, global::G.GetConnectedAccountsResponseItemStateVariant3ValVariant2, global::G.GetConnectedAccountsResponseItemStateVariant3ValVariant3, global::G.GetConnectedAccountsResponseItemStateVariant3ValVariant4> Val { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsResponseItemStateVariant3" /> class.
        /// </summary>
        /// <param name="val"></param>
        /// <param name="authScheme"></param>
        public GetConnectedAccountsResponseItemStateVariant3(
            global::G.OneOf<global::G.GetConnectedAccountsResponseItemStateVariant3ValVariant1, global::G.GetConnectedAccountsResponseItemStateVariant3ValVariant2, global::G.GetConnectedAccountsResponseItemStateVariant3ValVariant3, global::G.GetConnectedAccountsResponseItemStateVariant3ValVariant4> val,
            global::G.GetConnectedAccountsResponseItemStateVariant3AuthScheme authScheme)
        {
            this.AuthScheme = authScheme;
            this.Val = val;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsResponseItemStateVariant3" /> class.
        /// </summary>
        public GetConnectedAccountsResponseItemStateVariant3()
        {
        }
    }
}
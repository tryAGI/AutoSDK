//HintName: G.Models.GetConnectedAccountsResponseItemStateVariant8.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConnectedAccountsResponseItemStateVariant8
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authScheme")]
        public global::G.GetConnectedAccountsResponseItemStateVariant8AuthScheme AuthScheme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("val", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.GetConnectedAccountsResponseItemStateVariant8ValVariant1, global::G.GetConnectedAccountsResponseItemStateVariant8ValVariant2, global::G.GetConnectedAccountsResponseItemStateVariant8ValVariant3, global::G.GetConnectedAccountsResponseItemStateVariant8ValVariant4, global::G.GetConnectedAccountsResponseItemStateVariant8ValVariant5, global::G.GetConnectedAccountsResponseItemStateVariant8ValVariant6> Val { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsResponseItemStateVariant8" /> class.
        /// </summary>
        /// <param name="val"></param>
        /// <param name="authScheme"></param>
        public GetConnectedAccountsResponseItemStateVariant8(
            global::G.OneOf<global::G.GetConnectedAccountsResponseItemStateVariant8ValVariant1, global::G.GetConnectedAccountsResponseItemStateVariant8ValVariant2, global::G.GetConnectedAccountsResponseItemStateVariant8ValVariant3, global::G.GetConnectedAccountsResponseItemStateVariant8ValVariant4, global::G.GetConnectedAccountsResponseItemStateVariant8ValVariant5, global::G.GetConnectedAccountsResponseItemStateVariant8ValVariant6> val,
            global::G.GetConnectedAccountsResponseItemStateVariant8AuthScheme authScheme)
        {
            this.AuthScheme = authScheme;
            this.Val = val;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsResponseItemStateVariant8" /> class.
        /// </summary>
        public GetConnectedAccountsResponseItemStateVariant8()
        {
        }
    }
}
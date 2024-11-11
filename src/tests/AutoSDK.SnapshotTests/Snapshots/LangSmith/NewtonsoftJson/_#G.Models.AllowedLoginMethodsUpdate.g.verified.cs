//HintName: G.Models.AllowedLoginMethodsUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AllowedLoginMethodsUpdate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sso_only", Required = global::Newtonsoft.Json.Required.Always)]
        public bool SsoOnly { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AllowedLoginMethodsUpdate" /> class.
        /// </summary>
        /// <param name="ssoOnly"></param>
        public AllowedLoginMethodsUpdate(
            bool ssoOnly)
        {
            this.SsoOnly = ssoOnly;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AllowedLoginMethodsUpdate" /> class.
        /// </summary>
        public AllowedLoginMethodsUpdate()
        {
        }
    }
}
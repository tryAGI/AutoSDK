//HintName: G.Models.WebhooksSecurityAdvisoryVulnerabilitieFirstPatchedVersion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhooksSecurityAdvisoryVulnerabilitieFirstPatchedVersion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("identifier", Required = global::Newtonsoft.Json.Required.Always)]
        public string Identifier { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksSecurityAdvisoryVulnerabilitieFirstPatchedVersion" /> class.
        /// </summary>
        /// <param name="identifier"></param>
        public WebhooksSecurityAdvisoryVulnerabilitieFirstPatchedVersion(
            string identifier)
        {
            this.Identifier = identifier ?? throw new global::System.ArgumentNullException(nameof(identifier));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksSecurityAdvisoryVulnerabilitieFirstPatchedVersion" /> class.
        /// </summary>
        public WebhooksSecurityAdvisoryVulnerabilitieFirstPatchedVersion()
        {
        }
    }
}
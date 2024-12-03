//HintName: G.Models.SSOProviderSlim.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SSOProviderSlim
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProviderId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid OrganizationId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization_display_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string OrganizationDisplayName { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SSOProviderSlim" /> class.
        /// </summary>
        /// <param name="providerId"></param>
        /// <param name="organizationId"></param>
        /// <param name="organizationDisplayName"></param>
        public SSOProviderSlim(
            global::System.Guid providerId,
            global::System.Guid organizationId,
            string organizationDisplayName)
        {
            this.ProviderId = providerId;
            this.OrganizationId = organizationId;
            this.OrganizationDisplayName = organizationDisplayName ?? throw new global::System.ArgumentNullException(nameof(organizationDisplayName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SSOProviderSlim" /> class.
        /// </summary>
        public SSOProviderSlim()
        {
        }
    }
}
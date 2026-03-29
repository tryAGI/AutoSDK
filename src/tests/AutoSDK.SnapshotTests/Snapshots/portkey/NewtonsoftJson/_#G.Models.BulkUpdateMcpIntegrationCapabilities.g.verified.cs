//HintName: G.Models.BulkUpdateMcpIntegrationCapabilities.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BulkUpdateMcpIntegrationCapabilities
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("capabilities", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.BulkUpdateMcpIntegrationCapabilitiesCapabilitie> Capabilities { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateMcpIntegrationCapabilities" /> class.
        /// </summary>
        /// <param name="capabilities"></param>
        public BulkUpdateMcpIntegrationCapabilities(
            global::System.Collections.Generic.IList<global::G.BulkUpdateMcpIntegrationCapabilitiesCapabilitie> capabilities)
        {
            this.Capabilities = capabilities ?? throw new global::System.ArgumentNullException(nameof(capabilities));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateMcpIntegrationCapabilities" /> class.
        /// </summary>
        public BulkUpdateMcpIntegrationCapabilities()
        {
        }
    }
}
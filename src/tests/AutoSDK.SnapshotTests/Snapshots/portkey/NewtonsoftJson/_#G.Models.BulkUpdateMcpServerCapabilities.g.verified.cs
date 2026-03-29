//HintName: G.Models.BulkUpdateMcpServerCapabilities.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BulkUpdateMcpServerCapabilities
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("capabilities", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.BulkUpdateMcpServerCapabilitiesCapabilitie> Capabilities { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateMcpServerCapabilities" /> class.
        /// </summary>
        /// <param name="capabilities"></param>
        public BulkUpdateMcpServerCapabilities(
            global::System.Collections.Generic.IList<global::G.BulkUpdateMcpServerCapabilitiesCapabilitie> capabilities)
        {
            this.Capabilities = capabilities ?? throw new global::System.ArgumentNullException(nameof(capabilities));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateMcpServerCapabilities" /> class.
        /// </summary>
        public BulkUpdateMcpServerCapabilities()
        {
        }
    }
}
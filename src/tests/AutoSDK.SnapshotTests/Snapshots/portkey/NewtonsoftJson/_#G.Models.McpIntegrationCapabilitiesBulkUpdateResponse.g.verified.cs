//HintName: G.Models.McpIntegrationCapabilitiesBulkUpdateResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class McpIntegrationCapabilitiesBulkUpdateResponse
    {
        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpIntegrationCapabilitiesBulkUpdateResponse" /> class.
        /// </summary>
        /// <param name="success">
        /// Example: true
        /// </param>
        public McpIntegrationCapabilitiesBulkUpdateResponse(
            bool? success)
        {
            this.Success = success;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpIntegrationCapabilitiesBulkUpdateResponse" /> class.
        /// </summary>
        public McpIntegrationCapabilitiesBulkUpdateResponse()
        {
        }
    }
}
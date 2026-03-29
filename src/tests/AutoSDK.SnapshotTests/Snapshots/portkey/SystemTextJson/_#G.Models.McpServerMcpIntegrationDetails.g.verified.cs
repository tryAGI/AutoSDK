//HintName: G.Models.McpServerMcpIntegrationDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Present for system/service auth
    /// </summary>
    public sealed partial class McpServerMcpIntegrationDetails
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configurations")]
        public object? Configurations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transport")]
        public string? Transport { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_type")]
        public string? AuthType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServerMcpIntegrationDetails" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="slug"></param>
        /// <param name="status"></param>
        /// <param name="configurations"></param>
        /// <param name="url"></param>
        /// <param name="transport"></param>
        /// <param name="authType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public McpServerMcpIntegrationDetails(
            string? id,
            string? slug,
            string? status,
            object? configurations,
            string? url,
            string? transport,
            string? authType)
        {
            this.Id = id;
            this.Slug = slug;
            this.Status = status;
            this.Configurations = configurations;
            this.Url = url;
            this.Transport = transport;
            this.AuthType = authType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServerMcpIntegrationDetails" /> class.
        /// </summary>
        public McpServerMcpIntegrationDetails()
        {
        }
    }
}
//HintName: G.Models.CloudNotionPageDataSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CloudNotionPageDataSource
    {
        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supports_access_control")]
        public bool? SupportsAccessControl { get; set; }

        /// <summary>
        /// The integration token to use for authentication.<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integration_token")]
        public string? IntegrationToken { get; set; }

        /// <summary>
        /// The Notion Database Id to read content from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("database_ids")]
        public string? DatabaseIds { get; set; }

        /// <summary>
        /// The Page ID's of the Notion to read from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_ids")]
        public string? PageIds { get; set; }

        /// <summary>
        /// Default Value: CloudNotionPageDataSource
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("class_name")]
        public string? ClassName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudNotionPageDataSource" /> class.
        /// </summary>
        /// <param name="supportsAccessControl">
        /// Default Value: false
        /// </param>
        /// <param name="integrationToken">
        /// The integration token to use for authentication.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="databaseIds">
        /// The Notion Database Id to read content from.
        /// </param>
        /// <param name="pageIds">
        /// The Page ID's of the Notion to read from.
        /// </param>
        /// <param name="className">
        /// Default Value: CloudNotionPageDataSource
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CloudNotionPageDataSource(
            bool? supportsAccessControl,
            string? integrationToken,
            string? databaseIds,
            string? pageIds,
            string? className)
        {
            this.SupportsAccessControl = supportsAccessControl;
            this.IntegrationToken = integrationToken;
            this.DatabaseIds = databaseIds;
            this.PageIds = pageIds;
            this.ClassName = className;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudNotionPageDataSource" /> class.
        /// </summary>
        public CloudNotionPageDataSource()
        {
        }
    }
}
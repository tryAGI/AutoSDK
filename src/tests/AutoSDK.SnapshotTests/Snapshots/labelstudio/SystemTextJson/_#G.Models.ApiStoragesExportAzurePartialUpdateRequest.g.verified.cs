//HintName: G.Models.ApiStoragesExportAzurePartialUpdateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiStoragesExportAzurePartialUpdateRequest
    {
        /// <summary>
        /// Azure Blob account key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("account_key")]
        public string? AccountKey { get; set; }

        /// <summary>
        /// Azure Blob account name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("account_name")]
        public string? AccountName { get; set; }

        /// <summary>
        /// Deletion from storage enabled<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_delete_objects")]
        public bool? CanDeleteObjects { get; set; }

        /// <summary>
        /// Azure blob container
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("container")]
        public string? Container { get; set; }

        /// <summary>
        /// Storage description
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Azure blob prefix name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefix")]
        public string? Prefix { get; set; }

        /// <summary>
        /// Project ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        public int? Project { get; set; }

        /// <summary>
        /// Storage title
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiStoragesExportAzurePartialUpdateRequest" /> class.
        /// </summary>
        /// <param name="accountKey">
        /// Azure Blob account key
        /// </param>
        /// <param name="accountName">
        /// Azure Blob account name
        /// </param>
        /// <param name="canDeleteObjects">
        /// Deletion from storage enabled<br/>
        /// Default Value: false
        /// </param>
        /// <param name="container">
        /// Azure blob container
        /// </param>
        /// <param name="description">
        /// Storage description
        /// </param>
        /// <param name="prefix">
        /// Azure blob prefix name
        /// </param>
        /// <param name="project">
        /// Project ID
        /// </param>
        /// <param name="title">
        /// Storage title
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiStoragesExportAzurePartialUpdateRequest(
            string? accountKey,
            string? accountName,
            bool? canDeleteObjects,
            string? container,
            string? description,
            string? prefix,
            int? project,
            string? title)
        {
            this.AccountKey = accountKey;
            this.AccountName = accountName;
            this.CanDeleteObjects = canDeleteObjects;
            this.Container = container;
            this.Description = description;
            this.Prefix = prefix;
            this.Project = project;
            this.Title = title;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiStoragesExportAzurePartialUpdateRequest" /> class.
        /// </summary>
        public ApiStoragesExportAzurePartialUpdateRequest()
        {
        }
    }
}
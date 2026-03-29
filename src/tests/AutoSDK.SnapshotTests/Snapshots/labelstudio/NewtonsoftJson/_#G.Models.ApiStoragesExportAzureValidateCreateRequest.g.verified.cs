//HintName: G.Models.ApiStoragesExportAzureValidateCreateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiStoragesExportAzureValidateCreateRequest
    {
        /// <summary>
        /// Azure Blob account key
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("account_key")]
        public string? AccountKey { get; set; }

        /// <summary>
        /// Azure Blob account name
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("account_name")]
        public string? AccountName { get; set; }

        /// <summary>
        /// Deletion from storage enabled<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("can_delete_objects")]
        public bool? CanDeleteObjects { get; set; }

        /// <summary>
        /// Azure blob container
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("container")]
        public string? Container { get; set; }

        /// <summary>
        /// Storage description
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Storage ID. If set, storage with specified ID will be updated
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Azure blob prefix name
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prefix")]
        public string? Prefix { get; set; }

        /// <summary>
        /// Project ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project")]
        public int? Project { get; set; }

        /// <summary>
        /// Storage title
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiStoragesExportAzureValidateCreateRequest" /> class.
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
        /// <param name="id">
        /// Storage ID. If set, storage with specified ID will be updated
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
        public ApiStoragesExportAzureValidateCreateRequest(
            string? accountKey,
            string? accountName,
            bool? canDeleteObjects,
            string? container,
            string? description,
            int? id,
            string? prefix,
            int? project,
            string? title)
        {
            this.AccountKey = accountKey;
            this.AccountName = accountName;
            this.CanDeleteObjects = canDeleteObjects;
            this.Container = container;
            this.Description = description;
            this.Id = id;
            this.Prefix = prefix;
            this.Project = project;
            this.Title = title;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiStoragesExportAzureValidateCreateRequest" /> class.
        /// </summary>
        public ApiStoragesExportAzureValidateCreateRequest()
        {
        }
    }
}
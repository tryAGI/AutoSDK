//HintName: G.Models.ApiStoragesExportGcsValidateCreateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiStoragesExportGcsValidateCreateRequest
    {
        /// <summary>
        /// GCS bucket name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucket")]
        public string? Bucket { get; set; }

        /// <summary>
        /// Deletion from storage enabled.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_delete_objects")]
        public bool? CanDeleteObjects { get; set; }

        /// <summary>
        /// Storage description
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The content of GOOGLE_APPLICATION_CREDENTIALS json file. Check official Google Cloud Authentication documentation for more details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("google_application_credentials")]
        public string? GoogleApplicationCredentials { get; set; }

        /// <summary>
        /// Google project ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("google_project_id")]
        public string? GoogleProjectId { get; set; }

        /// <summary>
        /// Storage ID. If set, storage with specified ID will be updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// GCS bucket prefix
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
        /// Initializes a new instance of the <see cref="ApiStoragesExportGcsValidateCreateRequest" /> class.
        /// </summary>
        /// <param name="bucket">
        /// GCS bucket name
        /// </param>
        /// <param name="canDeleteObjects">
        /// Deletion from storage enabled.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="description">
        /// Storage description
        /// </param>
        /// <param name="googleApplicationCredentials">
        /// The content of GOOGLE_APPLICATION_CREDENTIALS json file. Check official Google Cloud Authentication documentation for more details.
        /// </param>
        /// <param name="googleProjectId">
        /// Google project ID
        /// </param>
        /// <param name="id">
        /// Storage ID. If set, storage with specified ID will be updated
        /// </param>
        /// <param name="prefix">
        /// GCS bucket prefix
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
        public ApiStoragesExportGcsValidateCreateRequest(
            string? bucket,
            bool? canDeleteObjects,
            string? description,
            string? googleApplicationCredentials,
            string? googleProjectId,
            int? id,
            string? prefix,
            int? project,
            string? title)
        {
            this.Bucket = bucket;
            this.CanDeleteObjects = canDeleteObjects;
            this.Description = description;
            this.GoogleApplicationCredentials = googleApplicationCredentials;
            this.GoogleProjectId = googleProjectId;
            this.Id = id;
            this.Prefix = prefix;
            this.Project = project;
            this.Title = title;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiStoragesExportGcsValidateCreateRequest" /> class.
        /// </summary>
        public ApiStoragesExportGcsValidateCreateRequest()
        {
        }
    }
}
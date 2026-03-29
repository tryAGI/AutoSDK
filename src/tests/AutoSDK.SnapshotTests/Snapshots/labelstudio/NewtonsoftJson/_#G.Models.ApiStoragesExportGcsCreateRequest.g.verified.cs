//HintName: G.Models.ApiStoragesExportGcsCreateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiStoragesExportGcsCreateRequest
    {
        /// <summary>
        /// GCS bucket name
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bucket")]
        public string? Bucket { get; set; }

        /// <summary>
        /// Deletion from storage enabled.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("can_delete_objects")]
        public bool? CanDeleteObjects { get; set; }

        /// <summary>
        /// Storage description
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The content of GOOGLE_APPLICATION_CREDENTIALS json file. Check official Google Cloud Authentication documentation for more details.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("google_application_credentials")]
        public string? GoogleApplicationCredentials { get; set; }

        /// <summary>
        /// Google project ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("google_project_id")]
        public string? GoogleProjectId { get; set; }

        /// <summary>
        /// GCS bucket prefix
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
        /// Initializes a new instance of the <see cref="ApiStoragesExportGcsCreateRequest" /> class.
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
        /// <param name="prefix">
        /// GCS bucket prefix
        /// </param>
        /// <param name="project">
        /// Project ID
        /// </param>
        /// <param name="title">
        /// Storage title
        /// </param>
        public ApiStoragesExportGcsCreateRequest(
            string? bucket,
            bool? canDeleteObjects,
            string? description,
            string? googleApplicationCredentials,
            string? googleProjectId,
            string? prefix,
            int? project,
            string? title)
        {
            this.Bucket = bucket;
            this.CanDeleteObjects = canDeleteObjects;
            this.Description = description;
            this.GoogleApplicationCredentials = googleApplicationCredentials;
            this.GoogleProjectId = googleProjectId;
            this.Prefix = prefix;
            this.Project = project;
            this.Title = title;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiStoragesExportGcsCreateRequest" /> class.
        /// </summary>
        public ApiStoragesExportGcsCreateRequest()
        {
        }
    }
}
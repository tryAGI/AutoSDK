//HintName: G.Models.GetMetaAndPointers.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Base model for schemas.
    /// </summary>
    public sealed partial class GetMetaAndPointers
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Public { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("website_url")]
        public string? WebsiteUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_url")]
        public string? RepositoryUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paper_url")]
        public string? PaperUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("license_url")]
        public string? LicenseUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pointers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Pointers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// A lean representation of a cluster when returned from an API call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cluster")]
        public global::G.PipelineClusterGetLean? Cluster { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accelerators")]
        public global::System.Collections.Generic.IList<global::G.Accelerator>? Accelerators { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMetaAndPointers" /> class.
        /// </summary>
        /// <param name="public"></param>
        /// <param name="description"></param>
        /// <param name="websiteUrl"></param>
        /// <param name="repositoryUrl"></param>
        /// <param name="paperUrl"></param>
        /// <param name="licenseUrl"></param>
        /// <param name="imageUrl"></param>
        /// <param name="pointers"></param>
        /// <param name="id"></param>
        /// <param name="createdAt"></param>
        /// <param name="cluster">
        /// A lean representation of a cluster when returned from an API call
        /// </param>
        /// <param name="accelerators"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetMetaAndPointers(
            bool @public,
            global::System.Collections.Generic.IList<string> pointers,
            string id,
            global::System.DateTime createdAt,
            string? description,
            string? websiteUrl,
            string? repositoryUrl,
            string? paperUrl,
            string? licenseUrl,
            string? imageUrl,
            global::G.PipelineClusterGetLean? cluster,
            global::System.Collections.Generic.IList<global::G.Accelerator>? accelerators)
        {
            this.Public = @public;
            this.Pointers = pointers ?? throw new global::System.ArgumentNullException(nameof(pointers));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.Description = description;
            this.WebsiteUrl = websiteUrl;
            this.RepositoryUrl = repositoryUrl;
            this.PaperUrl = paperUrl;
            this.LicenseUrl = licenseUrl;
            this.ImageUrl = imageUrl;
            this.Cluster = cluster;
            this.Accelerators = accelerators;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMetaAndPointers" /> class.
        /// </summary>
        public GetMetaAndPointers()
        {
        }
    }
}
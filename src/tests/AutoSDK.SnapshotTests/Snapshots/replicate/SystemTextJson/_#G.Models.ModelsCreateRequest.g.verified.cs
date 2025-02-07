//HintName: G.Models.ModelsCreateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelsCreateRequest
    {
        /// <summary>
        /// A URL for the model's cover image. This should be an image file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cover_image_url")]
        public string? CoverImageUrl { get; set; }

        /// <summary>
        /// A description of the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// A URL for the model's source code on GitHub.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("github_url")]
        public string? GithubUrl { get; set; }

        /// <summary>
        /// The SKU for the hardware used to run the model. Possible values can be retrieved from the `hardware.list` endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hardware")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Hardware { get; set; }

        /// <summary>
        /// A URL for the model's license.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("license_url")]
        public string? LicenseUrl { get; set; }

        /// <summary>
        /// The name of the model. This must be unique among all models owned by the user or organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The name of the user or organization that will own the model. This must be the same as the user or organization that is making the API request. In other words, the API token used in the request must belong to this user or organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Owner { get; set; }

        /// <summary>
        /// A URL for the model's paper.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paper_url")]
        public string? PaperUrl { get; set; }

        /// <summary>
        /// Whether the model should be public or private. A public model can be viewed and run by anyone, whereas a private model can be viewed and run only by the user or organization members that own the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ModelsCreateRequestVisibilityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ModelsCreateRequestVisibility Visibility { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsCreateRequest" /> class.
        /// </summary>
        /// <param name="coverImageUrl">
        /// A URL for the model's cover image. This should be an image file.
        /// </param>
        /// <param name="description">
        /// A description of the model.
        /// </param>
        /// <param name="githubUrl">
        /// A URL for the model's source code on GitHub.
        /// </param>
        /// <param name="hardware">
        /// The SKU for the hardware used to run the model. Possible values can be retrieved from the `hardware.list` endpoint.
        /// </param>
        /// <param name="licenseUrl">
        /// A URL for the model's license.
        /// </param>
        /// <param name="name">
        /// The name of the model. This must be unique among all models owned by the user or organization.
        /// </param>
        /// <param name="owner">
        /// The name of the user or organization that will own the model. This must be the same as the user or organization that is making the API request. In other words, the API token used in the request must belong to this user or organization.
        /// </param>
        /// <param name="paperUrl">
        /// A URL for the model's paper.
        /// </param>
        /// <param name="visibility">
        /// Whether the model should be public or private. A public model can be viewed and run by anyone, whereas a private model can be viewed and run only by the user or organization members that own the model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelsCreateRequest(
            string hardware,
            string name,
            string owner,
            global::G.ModelsCreateRequestVisibility visibility,
            string? coverImageUrl,
            string? description,
            string? githubUrl,
            string? licenseUrl,
            string? paperUrl)
        {
            this.Hardware = hardware ?? throw new global::System.ArgumentNullException(nameof(hardware));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Owner = owner ?? throw new global::System.ArgumentNullException(nameof(owner));
            this.Visibility = visibility;
            this.CoverImageUrl = coverImageUrl;
            this.Description = description;
            this.GithubUrl = githubUrl;
            this.LicenseUrl = licenseUrl;
            this.PaperUrl = paperUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsCreateRequest" /> class.
        /// </summary>
        public ModelsCreateRequest()
        {
        }
    }
}
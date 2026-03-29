//HintName: G.Models.VoiceLibrary.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoiceLibrary
    {
        /// <summary>
        /// This is the voice provider that will be used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        public object? Provider { get; set; }

        /// <summary>
        /// The ID of the voice provided by the provider.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("providerId")]
        public string? ProviderId { get; set; }

        /// <summary>
        /// The unique slug of the voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// The name of the voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The language of the voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language")]
        public string? Language { get; set; }

        /// <summary>
        /// The language code of the voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("languageCode")]
        public string? LanguageCode { get; set; }

        /// <summary>
        /// The model of the voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The supported models of the voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("supportedModels")]
        public string? SupportedModels { get; set; }

        /// <summary>
        /// The gender of the voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gender")]
        public global::G.VoiceLibraryGender? Gender { get; set; }

        /// <summary>
        /// The accent of the voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("accent")]
        public string? Accent { get; set; }

        /// <summary>
        /// The preview URL of the voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("previewUrl")]
        public string? PreviewUrl { get; set; }

        /// <summary>
        /// The sort order of the voice for display purposes. Lower values appear first.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sortOrder")]
        public double? SortOrder { get; set; }

        /// <summary>
        /// The description of the voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The credential ID of the voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("credentialId")]
        public string? CredentialId { get; set; }

        /// <summary>
        /// The unique identifier for the voice library.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The unique identifier for the organization that this voice library belongs to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("orgId", Required = global::Newtonsoft.Json.Required.Always)]
        public string OrgId { get; set; } = default!;

        /// <summary>
        /// The Public voice is shared accross all the organizations.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("isPublic", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsPublic { get; set; } = default!;

        /// <summary>
        /// The deletion status of the voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("isDeleted", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsDeleted { get; set; } = default!;

        /// <summary>
        /// The ISO 8601 date-time string of when the voice library was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// The ISO 8601 date-time string of when the voice library was last updated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updatedAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceLibrary" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier for the voice library.
        /// </param>
        /// <param name="orgId">
        /// The unique identifier for the organization that this voice library belongs to.
        /// </param>
        /// <param name="isPublic">
        /// The Public voice is shared accross all the organizations.
        /// </param>
        /// <param name="isDeleted">
        /// The deletion status of the voice.
        /// </param>
        /// <param name="createdAt">
        /// The ISO 8601 date-time string of when the voice library was created.
        /// </param>
        /// <param name="updatedAt">
        /// The ISO 8601 date-time string of when the voice library was last updated.
        /// </param>
        /// <param name="provider">
        /// This is the voice provider that will be used.
        /// </param>
        /// <param name="providerId">
        /// The ID of the voice provided by the provider.
        /// </param>
        /// <param name="slug">
        /// The unique slug of the voice.
        /// </param>
        /// <param name="name">
        /// The name of the voice.
        /// </param>
        /// <param name="language">
        /// The language of the voice.
        /// </param>
        /// <param name="languageCode">
        /// The language code of the voice.
        /// </param>
        /// <param name="model">
        /// The model of the voice.
        /// </param>
        /// <param name="supportedModels">
        /// The supported models of the voice.
        /// </param>
        /// <param name="gender">
        /// The gender of the voice.
        /// </param>
        /// <param name="accent">
        /// The accent of the voice.
        /// </param>
        /// <param name="previewUrl">
        /// The preview URL of the voice.
        /// </param>
        /// <param name="sortOrder">
        /// The sort order of the voice for display purposes. Lower values appear first.
        /// </param>
        /// <param name="description">
        /// The description of the voice.
        /// </param>
        /// <param name="credentialId">
        /// The credential ID of the voice.
        /// </param>
        public VoiceLibrary(
            string id,
            string orgId,
            bool isPublic,
            bool isDeleted,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            object? provider,
            string? providerId,
            string? slug,
            string? name,
            string? language,
            string? languageCode,
            string? model,
            string? supportedModels,
            global::G.VoiceLibraryGender? gender,
            string? accent,
            string? previewUrl,
            double? sortOrder,
            string? description,
            string? credentialId)
        {
            this.Provider = provider;
            this.ProviderId = providerId;
            this.Slug = slug;
            this.Name = name;
            this.Language = language;
            this.LanguageCode = languageCode;
            this.Model = model;
            this.SupportedModels = supportedModels;
            this.Gender = gender;
            this.Accent = accent;
            this.PreviewUrl = previewUrl;
            this.SortOrder = sortOrder;
            this.Description = description;
            this.CredentialId = credentialId;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OrgId = orgId ?? throw new global::System.ArgumentNullException(nameof(orgId));
            this.IsPublic = isPublic;
            this.IsDeleted = isDeleted;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceLibrary" /> class.
        /// </summary>
        public VoiceLibrary()
        {
        }
    }
}
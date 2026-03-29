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
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public object? Provider { get; set; }

        /// <summary>
        /// The ID of the voice provided by the provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerId")]
        public string? ProviderId { get; set; }

        /// <summary>
        /// The unique slug of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// The name of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The language of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// The language code of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languageCode")]
        public string? LanguageCode { get; set; }

        /// <summary>
        /// The model of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The supported models of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supportedModels")]
        public string? SupportedModels { get; set; }

        /// <summary>
        /// The gender of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gender")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.VoiceLibraryGenderJsonConverter))]
        public global::G.VoiceLibraryGender? Gender { get; set; }

        /// <summary>
        /// The accent of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accent")]
        public string? Accent { get; set; }

        /// <summary>
        /// The preview URL of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previewUrl")]
        public string? PreviewUrl { get; set; }

        /// <summary>
        /// The sort order of the voice for display purposes. Lower values appear first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sortOrder")]
        public double? SortOrder { get; set; }

        /// <summary>
        /// The description of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The credential ID of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credentialId")]
        public string? CredentialId { get; set; }

        /// <summary>
        /// The unique identifier for the voice library.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The unique identifier for the organization that this voice library belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrgId { get; set; }

        /// <summary>
        /// The Public voice is shared accross all the organizations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isPublic")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsPublic { get; set; }

        /// <summary>
        /// The deletion status of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isDeleted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsDeleted { get; set; }

        /// <summary>
        /// The ISO 8601 date-time string of when the voice library was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The ISO 8601 date-time string of when the voice library was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
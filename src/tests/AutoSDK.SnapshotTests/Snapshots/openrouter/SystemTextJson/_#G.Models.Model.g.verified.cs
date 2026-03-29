//HintName: G.Models.Model.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Information about an AI model available on OpenRouter
    /// </summary>
    public sealed partial class Model
    {
        /// <summary>
        /// Unique identifier for the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Canonical slug for the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("canonical_slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CanonicalSlug { get; set; }

        /// <summary>
        /// Hugging Face model identifier, if applicable
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hugging_face_id")]
        public string? HuggingFaceId { get; set; }

        /// <summary>
        /// Display name of the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Unix timestamp of when the model was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Created { get; set; }

        /// <summary>
        /// Description of the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Pricing information for the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricing")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PublicPricing Pricing { get; set; }

        /// <summary>
        /// Maximum context length in tokens
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_length")]
        public double? ContextLength { get; set; }

        /// <summary>
        /// Model architecture information
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("architecture")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ModelArchitecture Architecture { get; set; }

        /// <summary>
        /// Information about the top provider for this model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TopProviderInfo TopProvider { get; set; }

        /// <summary>
        /// Per-request token limits
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("per_request_limits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PerRequestLimits PerRequestLimits { get; set; }

        /// <summary>
        /// List of supported parameters for this model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported_parameters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Parameter> SupportedParameters { get; set; }

        /// <summary>
        /// Default parameters for this model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_parameters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DefaultParameters DefaultParameters { get; set; }

        /// <summary>
        /// The date up to which the model was trained on data. ISO 8601 date string (YYYY-MM-DD) or null if unknown.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("knowledge_cutoff")]
        public string? KnowledgeCutoff { get; set; }

        /// <summary>
        /// The date after which the model may be removed. ISO 8601 date string (YYYY-MM-DD) or null if no expiration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiration_date")]
        public string? ExpirationDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Model" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the model
        /// </param>
        /// <param name="canonicalSlug">
        /// Canonical slug for the model
        /// </param>
        /// <param name="name">
        /// Display name of the model
        /// </param>
        /// <param name="created">
        /// Unix timestamp of when the model was created
        /// </param>
        /// <param name="pricing">
        /// Pricing information for the model
        /// </param>
        /// <param name="architecture">
        /// Model architecture information
        /// </param>
        /// <param name="topProvider">
        /// Information about the top provider for this model
        /// </param>
        /// <param name="perRequestLimits">
        /// Per-request token limits
        /// </param>
        /// <param name="supportedParameters">
        /// List of supported parameters for this model
        /// </param>
        /// <param name="defaultParameters">
        /// Default parameters for this model
        /// </param>
        /// <param name="huggingFaceId">
        /// Hugging Face model identifier, if applicable
        /// </param>
        /// <param name="description">
        /// Description of the model
        /// </param>
        /// <param name="contextLength">
        /// Maximum context length in tokens
        /// </param>
        /// <param name="knowledgeCutoff">
        /// The date up to which the model was trained on data. ISO 8601 date string (YYYY-MM-DD) or null if unknown.
        /// </param>
        /// <param name="expirationDate">
        /// The date after which the model may be removed. ISO 8601 date string (YYYY-MM-DD) or null if no expiration.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Model(
            string id,
            string canonicalSlug,
            string name,
            double created,
            global::G.PublicPricing pricing,
            global::G.ModelArchitecture architecture,
            global::G.TopProviderInfo topProvider,
            global::G.PerRequestLimits perRequestLimits,
            global::System.Collections.Generic.IList<global::G.Parameter> supportedParameters,
            global::G.DefaultParameters defaultParameters,
            string? huggingFaceId,
            string? description,
            double? contextLength,
            string? knowledgeCutoff,
            string? expirationDate)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CanonicalSlug = canonicalSlug ?? throw new global::System.ArgumentNullException(nameof(canonicalSlug));
            this.HuggingFaceId = huggingFaceId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Created = created;
            this.Description = description;
            this.Pricing = pricing ?? throw new global::System.ArgumentNullException(nameof(pricing));
            this.ContextLength = contextLength;
            this.Architecture = architecture ?? throw new global::System.ArgumentNullException(nameof(architecture));
            this.TopProvider = topProvider ?? throw new global::System.ArgumentNullException(nameof(topProvider));
            this.PerRequestLimits = perRequestLimits ?? throw new global::System.ArgumentNullException(nameof(perRequestLimits));
            this.SupportedParameters = supportedParameters ?? throw new global::System.ArgumentNullException(nameof(supportedParameters));
            this.DefaultParameters = defaultParameters ?? throw new global::System.ArgumentNullException(nameof(defaultParameters));
            this.KnowledgeCutoff = knowledgeCutoff;
            this.ExpirationDate = expirationDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Model" /> class.
        /// </summary>
        public Model()
        {
        }
    }
}
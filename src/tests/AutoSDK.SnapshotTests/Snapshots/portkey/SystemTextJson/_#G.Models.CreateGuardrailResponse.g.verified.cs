//HintName: G.Models.CreateGuardrailResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateGuardrailResponse
    {
        /// <summary>
        /// Unique identifier of the created guardrail
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// URL-friendly slug for the guardrail
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// Version identifier for the guardrail configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VersionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGuardrailResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the created guardrail
        /// </param>
        /// <param name="slug">
        /// URL-friendly slug for the guardrail
        /// </param>
        /// <param name="versionId">
        /// Version identifier for the guardrail configuration
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateGuardrailResponse(
            string id,
            string slug,
            string versionId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.VersionId = versionId ?? throw new global::System.ArgumentNullException(nameof(versionId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGuardrailResponse" /> class.
        /// </summary>
        public CreateGuardrailResponse()
        {
        }
    }
}
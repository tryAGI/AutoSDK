//HintName: G.Models.UpdateGuardrailResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateGuardrailResponse
    {
        /// <summary>
        /// Unique identifier of the updated guardrail
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
        /// New version identifier after update
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_id")]
        public string? VersionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateGuardrailResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the updated guardrail
        /// </param>
        /// <param name="slug">
        /// URL-friendly slug for the guardrail
        /// </param>
        /// <param name="versionId">
        /// New version identifier after update
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateGuardrailResponse(
            string id,
            string slug,
            string? versionId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.VersionId = versionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateGuardrailResponse" /> class.
        /// </summary>
        public UpdateGuardrailResponse()
        {
        }
    }
}
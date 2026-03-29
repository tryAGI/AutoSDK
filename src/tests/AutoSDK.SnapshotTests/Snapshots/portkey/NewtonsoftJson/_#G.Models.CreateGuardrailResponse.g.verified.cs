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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// URL-friendly slug for the guardrail
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("slug", Required = global::Newtonsoft.Json.Required.Always)]
        public string Slug { get; set; } = default!;

        /// <summary>
        /// Version identifier for the guardrail configuration
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string VersionId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
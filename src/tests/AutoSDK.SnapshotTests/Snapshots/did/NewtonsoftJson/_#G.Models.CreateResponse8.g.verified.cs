//HintName: G.Models.CreateResponse8.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateResponse8
    {
        /// <summary>
        /// The ID of the consent
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Consent creation time as iso-8601 string
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// The user id of the user that created the consent
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_by", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedBy { get; set; } = default!;

        /// <summary>
        /// A random text with 3 words to be used as a consent
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResponse8" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the consent
        /// </param>
        /// <param name="createdAt">
        /// Consent creation time as iso-8601 string
        /// </param>
        /// <param name="createdBy">
        /// The user id of the user that created the consent
        /// </param>
        /// <param name="text">
        /// A random text with 3 words to be used as a consent
        /// </param>
        public CreateResponse8(
            string id,
            string createdAt,
            string createdBy,
            string text)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.CreatedBy = createdBy ?? throw new global::System.ArgumentNullException(nameof(createdBy));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResponse8" /> class.
        /// </summary>
        public CreateResponse8()
        {
        }
    }
}
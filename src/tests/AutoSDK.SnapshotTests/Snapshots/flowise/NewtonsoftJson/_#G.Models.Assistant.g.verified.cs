//HintName: G.Models.Assistant.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Assistant
    {
        /// <summary>
        /// Example: d290f1ee-6c54-4b01-90e6-d701748f0851
        /// </summary>
        /// <example>d290f1ee-6c54-4b01-90e6-d701748f0851</example>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("details")]
        public global::G.AssistantDetails? Details { get; set; }

        /// <summary>
        /// Example: 7db93c02-8d5a-4117-a8f1-3dfb6721b339
        /// </summary>
        /// <example>7db93c02-8d5a-4117-a8f1-3dfb6721b339</example>
        [global::Newtonsoft.Json.JsonProperty("credential")]
        public string? Credential { get; set; }

        /// <summary>
        /// Example: /images/assistant.png
        /// </summary>
        /// <example>/images/assistant.png</example>
        [global::Newtonsoft.Json.JsonProperty("iconSrc")]
        public string? IconSrc { get; set; }

        /// <summary>
        /// Example: 2024-08-24T14:15:22Z
        /// </summary>
        /// <example>2024-08-24T14:15:22Z</example>
        [global::Newtonsoft.Json.JsonProperty("createdDate")]
        public global::System.DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Example: 2024-08-24T14:15:22Z
        /// </summary>
        /// <example>2024-08-24T14:15:22Z</example>
        [global::Newtonsoft.Json.JsonProperty("updatedDate")]
        public global::System.DateTime? UpdatedDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Assistant" /> class.
        /// </summary>
        /// <param name="id">
        /// Example: d290f1ee-6c54-4b01-90e6-d701748f0851
        /// </param>
        /// <param name="details"></param>
        /// <param name="credential">
        /// Example: 7db93c02-8d5a-4117-a8f1-3dfb6721b339
        /// </param>
        /// <param name="iconSrc">
        /// Example: /images/assistant.png
        /// </param>
        /// <param name="createdDate">
        /// Example: 2024-08-24T14:15:22Z
        /// </param>
        /// <param name="updatedDate">
        /// Example: 2024-08-24T14:15:22Z
        /// </param>
        public Assistant(
            string? id,
            global::G.AssistantDetails? details,
            string? credential,
            string? iconSrc,
            global::System.DateTime? createdDate,
            global::System.DateTime? updatedDate)
        {
            this.Id = id;
            this.Details = details;
            this.Credential = credential;
            this.IconSrc = iconSrc;
            this.CreatedDate = createdDate;
            this.UpdatedDate = updatedDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Assistant" /> class.
        /// </summary>
        public Assistant()
        {
        }
    }
}
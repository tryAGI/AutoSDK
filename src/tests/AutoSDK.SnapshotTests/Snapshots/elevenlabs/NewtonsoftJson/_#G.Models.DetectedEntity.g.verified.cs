//HintName: G.Models.DetectedEntity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DetectedEntity
    {
        /// <summary>
        /// The text that was identified as an entity.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// The type of entity detected (e.g., 'credit_card', 'email_address', 'person_name').
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("entity_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string EntityType { get; set; } = default!;

        /// <summary>
        /// Start character position in the transcript text.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_char", Required = global::Newtonsoft.Json.Required.Always)]
        public int StartChar { get; set; } = default!;

        /// <summary>
        /// End character position in the transcript text.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_char", Required = global::Newtonsoft.Json.Required.Always)]
        public int EndChar { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectedEntity" /> class.
        /// </summary>
        /// <param name="text">
        /// The text that was identified as an entity.
        /// </param>
        /// <param name="entityType">
        /// The type of entity detected (e.g., 'credit_card', 'email_address', 'person_name').
        /// </param>
        /// <param name="startChar">
        /// Start character position in the transcript text.
        /// </param>
        /// <param name="endChar">
        /// End character position in the transcript text.
        /// </param>
        public DetectedEntity(
            string text,
            string entityType,
            int startChar,
            int endChar)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.EntityType = entityType ?? throw new global::System.ArgumentNullException(nameof(entityType));
            this.StartChar = startChar;
            this.EndChar = endChar;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectedEntity" /> class.
        /// </summary>
        public DetectedEntity()
        {
        }
    }
}
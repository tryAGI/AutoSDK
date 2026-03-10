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
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// The type of entity detected (e.g., 'credit_card', 'email_address', 'person_name').
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EntityType { get; set; }

        /// <summary>
        /// Start character position in the transcript text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_char")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartChar { get; set; }

        /// <summary>
        /// End character position in the transcript text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_char")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EndChar { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
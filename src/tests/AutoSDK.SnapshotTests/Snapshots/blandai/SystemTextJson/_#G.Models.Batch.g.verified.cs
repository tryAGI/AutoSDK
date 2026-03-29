//HintName: G.Models.Batch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Batch
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Organization ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// JSON string with shared call properties
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_prompt")]
        public string? BasePrompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_objects")]
        public global::System.Collections.Generic.IList<object>? CallObjects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Batch" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userId">
        /// Organization ID
        /// </param>
        /// <param name="basePrompt">
        /// JSON string with shared call properties
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="callObjects"></param>
        /// <param name="description"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Batch(
            string? id,
            string? userId,
            string? basePrompt,
            global::System.DateTime? createdAt,
            global::System.Collections.Generic.IList<object>? callObjects,
            string? description)
        {
            this.Id = id;
            this.UserId = userId;
            this.BasePrompt = basePrompt;
            this.CreatedAt = createdAt;
            this.CallObjects = callObjects;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Batch" /> class.
        /// </summary>
        public Batch()
        {
        }
    }
}
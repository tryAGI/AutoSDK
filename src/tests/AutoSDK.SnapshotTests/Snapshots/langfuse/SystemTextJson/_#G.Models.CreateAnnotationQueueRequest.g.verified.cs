//HintName: G.Models.CreateAnnotationQueueRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAnnotationQueueRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scoreConfigIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ScoreConfigIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAnnotationQueueRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="scoreConfigIds"></param>
        /// <param name="description"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAnnotationQueueRequest(
            string name,
            global::System.Collections.Generic.IList<string> scoreConfigIds,
            string? description)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.ScoreConfigIds = scoreConfigIds ?? throw new global::System.ArgumentNullException(nameof(scoreConfigIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAnnotationQueueRequest" /> class.
        /// </summary>
        public CreateAnnotationQueueRequest()
        {
        }
    }
}
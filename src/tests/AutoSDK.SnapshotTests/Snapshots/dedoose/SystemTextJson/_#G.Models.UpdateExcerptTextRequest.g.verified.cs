//HintName: G.Models.UpdateExcerptTextRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateExcerptTextRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectIDL")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectIDL { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excerptId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ExcerptId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateExcerptTextRequest" /> class.
        /// </summary>
        /// <param name="projectIDL"></param>
        /// <param name="excerptId"></param>
        /// <param name="text"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateExcerptTextRequest(
            global::System.Guid projectIDL,
            global::System.Guid excerptId,
            string text)
        {
            this.ProjectIDL = projectIDL;
            this.ExcerptId = excerptId;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateExcerptTextRequest" /> class.
        /// </summary>
        public UpdateExcerptTextRequest()
        {
        }
    }
}
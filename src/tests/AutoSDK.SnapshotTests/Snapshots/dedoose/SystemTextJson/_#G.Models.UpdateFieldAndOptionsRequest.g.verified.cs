//HintName: G.Models.UpdateFieldAndOptionsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateFieldAndOptionsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fieldId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid FieldId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.FieldOptionVO> Options { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deletedOptionIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> DeletedOptionIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFieldAndOptionsRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="fieldId"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="options"></param>
        /// <param name="deletedOptionIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateFieldAndOptionsRequest(
            global::System.Guid projectId,
            global::System.Guid fieldId,
            string title,
            string description,
            global::System.Collections.Generic.IList<global::G.FieldOptionVO> options,
            global::System.Collections.Generic.IList<global::System.Guid> deletedOptionIds)
        {
            this.ProjectId = projectId;
            this.FieldId = fieldId;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            this.DeletedOptionIds = deletedOptionIds ?? throw new global::System.ArgumentNullException(nameof(deletedOptionIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFieldAndOptionsRequest" /> class.
        /// </summary>
        public UpdateFieldAndOptionsRequest()
        {
        }
    }
}
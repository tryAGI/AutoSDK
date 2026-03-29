//HintName: G.Models.LabelCreateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LabelCreateRequest
    {
        /// <summary>
        /// Status of label
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("approved")]
        public bool? Approved { get; set; }

        /// <summary>
        /// User who approved this label
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("approved_by")]
        public int? ApprovedBy { get; set; }

        /// <summary>
        /// Label description
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FromName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Project { get; set; }

        /// <summary>
        /// Label title
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// Label value
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelCreateRequest" /> class.
        /// </summary>
        /// <param name="fromName"></param>
        /// <param name="project"></param>
        /// <param name="title">
        /// Label title
        /// </param>
        /// <param name="value">
        /// Label value
        /// </param>
        /// <param name="approved">
        /// Status of label
        /// </param>
        /// <param name="approvedBy">
        /// User who approved this label
        /// </param>
        /// <param name="description">
        /// Label description
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LabelCreateRequest(
            string fromName,
            int project,
            string title,
            object value,
            bool? approved,
            int? approvedBy,
            string? description)
        {
            this.Approved = approved;
            this.ApprovedBy = approvedBy;
            this.Description = description;
            this.FromName = fromName ?? throw new global::System.ArgumentNullException(nameof(fromName));
            this.Project = project;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelCreateRequest" /> class.
        /// </summary>
        public LabelCreateRequest()
        {
        }
    }
}
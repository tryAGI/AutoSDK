//HintName: G.Models.PatchedLabelRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A ModelSerializer that takes additional arguments for<br/>
    /// "fields", "omit" and "expand" in order to<br/>
    /// control which fields are displayed, and whether to replace simple<br/>
    /// values with complex, nested serializations
    /// </summary>
    public sealed partial class PatchedLabelRequest
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
        /// User who made this label
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public int? CreatedBy { get; set; }

        /// <summary>
        /// Label description
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        public int? Organization { get; set; }

        /// <summary>
        /// Label title
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Label value
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public object? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedLabelRequest" /> class.
        /// </summary>
        /// <param name="approved">
        /// Status of label
        /// </param>
        /// <param name="approvedBy">
        /// User who approved this label
        /// </param>
        /// <param name="createdBy">
        /// User who made this label
        /// </param>
        /// <param name="description">
        /// Label description
        /// </param>
        /// <param name="organization"></param>
        /// <param name="title">
        /// Label title
        /// </param>
        /// <param name="value">
        /// Label value
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchedLabelRequest(
            bool? approved,
            int? approvedBy,
            int? createdBy,
            string? description,
            int? organization,
            string? title,
            object? value)
        {
            this.Approved = approved;
            this.ApprovedBy = approvedBy;
            this.CreatedBy = createdBy;
            this.Description = description;
            this.Organization = organization;
            this.Title = title;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedLabelRequest" /> class.
        /// </summary>
        public PatchedLabelRequest()
        {
        }
    }
}
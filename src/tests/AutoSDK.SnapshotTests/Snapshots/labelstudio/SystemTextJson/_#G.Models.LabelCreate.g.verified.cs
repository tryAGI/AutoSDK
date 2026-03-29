//HintName: G.Models.LabelCreate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LabelCreate
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
        /// Time of label creation<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public int CreatedBy { get; set; } = default!;

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
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        public int Organization { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Project { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects")]
        public global::System.Collections.Generic.IList<int> Projects { get; set; } = default!;

        /// <summary>
        /// Label title
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// Time of label modification<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="LabelCreate" /> class.
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
        /// <param name="createdAt">
        /// Time of label creation<br/>
        /// Included only in responses
        /// </param>
        /// <param name="createdBy">
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="organization">
        /// Included only in responses
        /// </param>
        /// <param name="projects">
        /// Included only in responses
        /// </param>
        /// <param name="updatedAt">
        /// Time of label modification<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LabelCreate(
            string fromName,
            int project,
            string title,
            object value,
            bool? approved,
            int? approvedBy,
            string? description,
            global::System.DateTime createdAt = default!,
            int createdBy = default!,
            int id = default!,
            int organization = default!,
            global::System.Collections.Generic.IList<int> projects = default!,
            global::System.DateTime updatedAt = default!)
        {
            this.Approved = approved;
            this.ApprovedBy = approvedBy;
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.Description = description;
            this.FromName = fromName ?? throw new global::System.ArgumentNullException(nameof(fromName));
            this.Id = id;
            this.Organization = organization;
            this.Project = project;
            this.Projects = projects;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.UpdatedAt = updatedAt;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelCreate" /> class.
        /// </summary>
        public LabelCreate()
        {
        }
    }
}
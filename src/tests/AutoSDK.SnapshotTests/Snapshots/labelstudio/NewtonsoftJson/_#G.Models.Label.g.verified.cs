//HintName: G.Models.Label.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A ModelSerializer that takes additional arguments for<br/>
    /// "fields", "omit" and "expand" in order to<br/>
    /// control which fields are displayed, and whether to replace simple<br/>
    /// values with complex, nested serializations
    /// </summary>
    public sealed partial class Label
    {
        /// <summary>
        /// Status of label
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("approved")]
        public bool? Approved { get; set; }

        /// <summary>
        /// User who approved this label
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("approved_by")]
        public int? ApprovedBy { get; set; }

        /// <summary>
        /// Time of label creation<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// User who made this label
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_by", Required = global::Newtonsoft.Json.Required.Always)]
        public int CreatedBy { get; set; } = default!;

        /// <summary>
        /// Label description
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("links")]
        public global::System.Collections.Generic.IList<int> Links { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization", Required = global::Newtonsoft.Json.Required.Always)]
        public int Organization { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("projects")]
        public global::System.Collections.Generic.IList<int> Projects { get; set; } = default!;

        /// <summary>
        /// Label title
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// Time of label modification<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Label value
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public object Value { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Label" /> class.
        /// </summary>
        /// <param name="createdBy">
        /// User who made this label
        /// </param>
        /// <param name="organization"></param>
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
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="links">
        /// Included only in responses
        /// </param>
        /// <param name="projects">
        /// Included only in responses
        /// </param>
        /// <param name="updatedAt">
        /// Time of label modification<br/>
        /// Included only in responses
        /// </param>
        public Label(
            int createdBy,
            int organization,
            string title,
            object value,
            bool? approved,
            int? approvedBy,
            string? description,
            global::System.DateTime createdAt = default!,
            int id = default!,
            global::System.Collections.Generic.IList<int> links = default!,
            global::System.Collections.Generic.IList<int> projects = default!,
            global::System.DateTime updatedAt = default!)
        {
            this.Approved = approved;
            this.ApprovedBy = approvedBy;
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.Description = description;
            this.Id = id;
            this.Links = links;
            this.Organization = organization;
            this.Projects = projects;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.UpdatedAt = updatedAt;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Label" /> class.
        /// </summary>
        public Label()
        {
        }
    }
}
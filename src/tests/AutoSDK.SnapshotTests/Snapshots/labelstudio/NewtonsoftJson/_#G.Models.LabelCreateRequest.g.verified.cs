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
        [global::Newtonsoft.Json.JsonProperty("approved")]
        public bool? Approved { get; set; }

        /// <summary>
        /// User who approved this label
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("approved_by")]
        public int? ApprovedBy { get; set; }

        /// <summary>
        /// Label description
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("from_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string FromName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project", Required = global::Newtonsoft.Json.Required.Always)]
        public int Project { get; set; } = default!;

        /// <summary>
        /// Label title
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

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
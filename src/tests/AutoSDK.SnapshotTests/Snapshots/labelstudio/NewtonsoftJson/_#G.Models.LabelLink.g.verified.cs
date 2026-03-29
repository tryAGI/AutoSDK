//HintName: G.Models.LabelLink.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A ModelSerializer that takes additional arguments for<br/>
    /// "fields", "omit" and "expand" in order to<br/>
    /// control which fields are displayed, and whether to replace simple<br/>
    /// values with complex, nested serializations
    /// </summary>
    public sealed partial class LabelLink
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("annotations_count")]
        public int AnnotationsCount { get; set; } = default!;

        /// <summary>
        /// Tag name
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("from_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string FromName { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("label", Required = global::Newtonsoft.Json.Required.Always)]
        public int Label { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project", Required = global::Newtonsoft.Json.Required.Always)]
        public int Project { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelLink" /> class.
        /// </summary>
        /// <param name="fromName">
        /// Tag name
        /// </param>
        /// <param name="label"></param>
        /// <param name="project"></param>
        /// <param name="annotationsCount">
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        public LabelLink(
            string fromName,
            int label,
            int project,
            int annotationsCount = default!,
            int id = default!)
        {
            this.AnnotationsCount = annotationsCount;
            this.FromName = fromName ?? throw new global::System.ArgumentNullException(nameof(fromName));
            this.Id = id;
            this.Label = label;
            this.Project = project;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelLink" /> class.
        /// </summary>
        public LabelLink()
        {
        }
    }
}
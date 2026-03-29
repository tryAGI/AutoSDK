//HintName: G.Models.LabelLinkRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A ModelSerializer that takes additional arguments for<br/>
    /// "fields", "omit" and "expand" in order to<br/>
    /// control which fields are displayed, and whether to replace simple<br/>
    /// values with complex, nested serializations
    /// </summary>
    public sealed partial class LabelLinkRequest
    {
        /// <summary>
        /// Tag name
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("from_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string FromName { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="LabelLinkRequest" /> class.
        /// </summary>
        /// <param name="fromName">
        /// Tag name
        /// </param>
        /// <param name="label"></param>
        /// <param name="project"></param>
        public LabelLinkRequest(
            string fromName,
            int label,
            int project)
        {
            this.FromName = fromName ?? throw new global::System.ArgumentNullException(nameof(fromName));
            this.Label = label;
            this.Project = project;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelLinkRequest" /> class.
        /// </summary>
        public LabelLinkRequest()
        {
        }
    }
}
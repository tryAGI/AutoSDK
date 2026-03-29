//HintName: G.Models.ProjectLabelConfigRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectLabelConfigRequest
    {
        /// <summary>
        /// Label config in XML format. See more about it in documentation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("label_config", Required = global::Newtonsoft.Json.Required.Always)]
        public string LabelConfig { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectLabelConfigRequest" /> class.
        /// </summary>
        /// <param name="labelConfig">
        /// Label config in XML format. See more about it in documentation
        /// </param>
        public ProjectLabelConfigRequest(
            string labelConfig)
        {
            this.LabelConfig = labelConfig ?? throw new global::System.ArgumentNullException(nameof(labelConfig));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectLabelConfigRequest" /> class.
        /// </summary>
        public ProjectLabelConfigRequest()
        {
        }
    }
}
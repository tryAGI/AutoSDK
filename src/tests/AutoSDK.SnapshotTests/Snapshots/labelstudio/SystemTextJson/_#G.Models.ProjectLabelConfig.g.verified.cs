//HintName: G.Models.ProjectLabelConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectLabelConfig
    {
        /// <summary>
        /// Label config in XML format. See more about it in documentation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label_config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LabelConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectLabelConfig" /> class.
        /// </summary>
        /// <param name="labelConfig">
        /// Label config in XML format. See more about it in documentation
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectLabelConfig(
            string labelConfig)
        {
            this.LabelConfig = labelConfig ?? throw new global::System.ArgumentNullException(nameof(labelConfig));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectLabelConfig" /> class.
        /// </summary>
        public ProjectLabelConfig()
        {
        }
    }
}
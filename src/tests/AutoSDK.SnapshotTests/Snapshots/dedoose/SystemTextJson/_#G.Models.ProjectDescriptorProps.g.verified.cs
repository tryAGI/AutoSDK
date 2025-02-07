//HintName: G.Models.ProjectDescriptorProps.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectDescriptorProps
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectDescriptorSets")]
        public global::System.Collections.Generic.IList<global::G.DescriptorSet>? ProjectDescriptorSets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectDescriptorFields")]
        public global::System.Collections.Generic.IList<global::G.DescriptorField>? ProjectDescriptorFields { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectDescriptorFieldOptions")]
        public global::System.Collections.Generic.IList<global::G.DescriptorFieldOption>? ProjectDescriptorFieldOptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectDescriptorProps" /> class.
        /// </summary>
        /// <param name="projectDescriptorSets"></param>
        /// <param name="projectDescriptorFields"></param>
        /// <param name="projectDescriptorFieldOptions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectDescriptorProps(
            global::System.Collections.Generic.IList<global::G.DescriptorSet>? projectDescriptorSets,
            global::System.Collections.Generic.IList<global::G.DescriptorField>? projectDescriptorFields,
            global::System.Collections.Generic.IList<global::G.DescriptorFieldOption>? projectDescriptorFieldOptions)
        {
            this.ProjectDescriptorSets = projectDescriptorSets;
            this.ProjectDescriptorFields = projectDescriptorFields;
            this.ProjectDescriptorFieldOptions = projectDescriptorFieldOptions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectDescriptorProps" /> class.
        /// </summary>
        public ProjectDescriptorProps()
        {
        }
    }
}
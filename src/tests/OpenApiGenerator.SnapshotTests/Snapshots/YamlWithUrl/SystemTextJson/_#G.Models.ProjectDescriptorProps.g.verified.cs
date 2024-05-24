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
        public global::System.Collections.Generic.IList<DescriptorSet>? ProjectDescriptorSets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectDescriptorFields")]
        public global::System.Collections.Generic.IList<DescriptorField>? ProjectDescriptorFields { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectDescriptorFieldOptions")]
        public global::System.Collections.Generic.IList<DescriptorFieldOption>? ProjectDescriptorFieldOptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
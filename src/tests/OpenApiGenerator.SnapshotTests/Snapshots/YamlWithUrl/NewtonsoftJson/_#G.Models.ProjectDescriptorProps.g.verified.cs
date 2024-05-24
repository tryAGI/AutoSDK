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
        [global::Newtonsoft.Json.JsonProperty("projectDescriptorSets")]
        public global::System.Collections.Generic.IList<DescriptorSet>? ProjectDescriptorSets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectDescriptorFields")]
        public global::System.Collections.Generic.IList<DescriptorField>? ProjectDescriptorFields { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectDescriptorFieldOptions")]
        public global::System.Collections.Generic.IList<DescriptorFieldOption>? ProjectDescriptorFieldOptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
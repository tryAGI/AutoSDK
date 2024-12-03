//HintName: G.Models.DescriptorFieldWithOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DescriptorFieldWithOptions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("field")]
        public global::G.DescriptorField2? Field { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("options")]
        public global::System.Collections.Generic.IList<global::G.DescriptorFieldOption>? Options { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DescriptorFieldWithOptions" /> class.
        /// </summary>
        /// <param name="field"></param>
        /// <param name="options"></param>
        public DescriptorFieldWithOptions(
            global::G.DescriptorField2? field,
            global::System.Collections.Generic.IList<global::G.DescriptorFieldOption>? options)
        {
            this.Field = field;
            this.Options = options;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DescriptorFieldWithOptions" /> class.
        /// </summary>
        public DescriptorFieldWithOptions()
        {
        }
    }
}
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
        [global::System.Text.Json.Serialization.JsonPropertyName("field")]
        public global::G.DescriptorField? Field { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        public global::System.Collections.Generic.IList<global::G.DescriptorFieldOption>? Options { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DescriptorFieldWithOptions" /> class.
        /// </summary>
        /// <param name="field"></param>
        /// <param name="options"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public DescriptorFieldWithOptions(
            global::G.DescriptorField? field,
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
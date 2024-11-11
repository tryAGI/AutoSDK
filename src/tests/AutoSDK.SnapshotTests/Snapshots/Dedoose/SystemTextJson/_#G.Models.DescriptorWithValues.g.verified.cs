//HintName: G.Models.DescriptorWithValues.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DescriptorWithValues
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item")]
        public global::G.Descriptor? Item { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        public global::System.Collections.Generic.IList<global::G.DescriptorValueDTO>? Values { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DescriptorWithValues" /> class.
        /// </summary>
        /// <param name="item"></param>
        /// <param name="values"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public DescriptorWithValues(
            global::G.Descriptor? item,
            global::System.Collections.Generic.IList<global::G.DescriptorValueDTO>? values)
        {
            this.Item = item;
            this.Values = values;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DescriptorWithValues" /> class.
        /// </summary>
        public DescriptorWithValues()
        {
        }
    }
}
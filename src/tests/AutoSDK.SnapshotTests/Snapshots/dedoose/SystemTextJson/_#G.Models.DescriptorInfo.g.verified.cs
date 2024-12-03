//HintName: G.Models.DescriptorInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DescriptorInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("descriptorId")]
        public global::System.Guid? DescriptorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fieldValues")]
        public global::System.Collections.Generic.IList<global::G.FieldValueDTO>? FieldValues { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DescriptorInfo" /> class.
        /// </summary>
        /// <param name="descriptorId"></param>
        /// <param name="fieldValues"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public DescriptorInfo(
            global::System.Guid? descriptorId,
            global::System.Collections.Generic.IList<global::G.FieldValueDTO>? fieldValues)
        {
            this.DescriptorId = descriptorId;
            this.FieldValues = fieldValues;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DescriptorInfo" /> class.
        /// </summary>
        public DescriptorInfo()
        {
        }
    }
}
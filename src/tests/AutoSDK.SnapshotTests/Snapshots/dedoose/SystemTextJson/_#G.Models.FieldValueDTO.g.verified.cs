//HintName: G.Models.FieldValueDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FieldValueDTO
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("descriptorId")]
        public global::System.Guid? DescriptorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fieldId")]
        public global::System.Guid? FieldId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("optionId")]
        public global::System.Guid? OptionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FieldValueDTO" /> class.
        /// </summary>
        /// <param name="descriptorId"></param>
        /// <param name="fieldId"></param>
        /// <param name="value"></param>
        /// <param name="optionId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FieldValueDTO(
            global::System.Guid? descriptorId,
            global::System.Guid? fieldId,
            string? value,
            global::System.Guid? optionId)
        {
            this.DescriptorId = descriptorId;
            this.FieldId = fieldId;
            this.Value = value;
            this.OptionId = optionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FieldValueDTO" /> class.
        /// </summary>
        public FieldValueDTO()
        {
        }
    }
}
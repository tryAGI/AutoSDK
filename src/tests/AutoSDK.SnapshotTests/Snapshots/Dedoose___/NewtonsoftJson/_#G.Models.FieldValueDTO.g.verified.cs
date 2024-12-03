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
        [global::Newtonsoft.Json.JsonProperty("descriptorId")]
        public global::System.Guid? DescriptorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fieldId")]
        public global::System.Guid? FieldId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value")]
        public string? Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("optionId")]
        public global::System.Guid? OptionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FieldValueDTO" /> class.
        /// </summary>
        /// <param name="descriptorId"></param>
        /// <param name="fieldId"></param>
        /// <param name="value"></param>
        /// <param name="optionId"></param>
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
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
        [global::Newtonsoft.Json.JsonProperty("descriptorId")]
        public global::System.Guid? DescriptorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fieldValues")]
        public global::System.Collections.Generic.IList<global::G.FieldValueDTO>? FieldValues { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DescriptorInfo" /> class.
        /// </summary>
        /// <param name="descriptorId"></param>
        /// <param name="fieldValues"></param>
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
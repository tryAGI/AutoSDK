//HintName: G.Models.DescriptorLinkVO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DescriptorLinkVO
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("descriptorId")]
        public global::System.Guid? DescriptorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceId")]
        public global::System.Guid? ResourceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DescriptorLinkVO" /> class.
        /// </summary>
        /// <param name="descriptorId"></param>
        /// <param name="resourceId"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public DescriptorLinkVO(
            global::System.Guid? descriptorId,
            global::System.Guid? resourceId)
        {
            this.DescriptorId = descriptorId;
            this.ResourceId = resourceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DescriptorLinkVO" /> class.
        /// </summary>
        public DescriptorLinkVO()
        {
        }
    }
}
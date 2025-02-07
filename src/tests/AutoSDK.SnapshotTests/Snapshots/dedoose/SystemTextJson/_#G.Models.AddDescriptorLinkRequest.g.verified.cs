//HintName: G.Models.AddDescriptorLinkRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddDescriptorLinkRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ResourceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("descriptorId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid DescriptorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamicValues")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.FieldValueDTO> DynamicValues { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddDescriptorLinkRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="resourceId"></param>
        /// <param name="descriptorId"></param>
        /// <param name="dynamicValues"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddDescriptorLinkRequest(
            global::System.Guid projectId,
            global::System.Guid resourceId,
            global::System.Guid descriptorId,
            global::System.Collections.Generic.IList<global::G.FieldValueDTO> dynamicValues)
        {
            this.ProjectId = projectId;
            this.ResourceId = resourceId;
            this.DescriptorId = descriptorId;
            this.DynamicValues = dynamicValues ?? throw new global::System.ArgumentNullException(nameof(dynamicValues));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddDescriptorLinkRequest" /> class.
        /// </summary>
        public AddDescriptorLinkRequest()
        {
        }
    }
}
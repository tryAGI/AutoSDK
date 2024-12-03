//HintName: G.Models.ForceDeleteDescriptorSetPolledRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ForceDeleteDescriptorSetPolledRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectIDL")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectIDL { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("descriptorSetId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid DescriptorSetId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ForceDeleteDescriptorSetPolledRequest" /> class.
        /// </summary>
        /// <param name="projectIDL"></param>
        /// <param name="descriptorSetId"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ForceDeleteDescriptorSetPolledRequest(
            global::System.Guid projectIDL,
            global::System.Guid descriptorSetId)
        {
            this.ProjectIDL = projectIDL;
            this.DescriptorSetId = descriptorSetId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ForceDeleteDescriptorSetPolledRequest" /> class.
        /// </summary>
        public ForceDeleteDescriptorSetPolledRequest()
        {
        }
    }
}
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
        [global::Newtonsoft.Json.JsonProperty("projectIDL", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectIDL { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("descriptorSetId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid DescriptorSetId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ForceDeleteDescriptorSetPolledRequest" /> class.
        /// </summary>
        /// <param name="projectIDL"></param>
        /// <param name="descriptorSetId"></param>
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
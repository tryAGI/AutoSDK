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
        [global::Newtonsoft.Json.JsonProperty("projectId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resourceId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ResourceId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("descriptorId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid DescriptorId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dynamicValues", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.FieldValueDTO> DynamicValues { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddDescriptorLinkRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="resourceId"></param>
        /// <param name="descriptorId"></param>
        /// <param name="dynamicValues"></param>
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
//HintName: G.Models.AddDynamicValueRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddDynamicValueRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("setId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid SetId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("descriptorId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid DescriptorId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fieldId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid FieldId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resourceId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ResourceId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public string Data { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("optionId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid OptionId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddDynamicValueRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="setId"></param>
        /// <param name="descriptorId"></param>
        /// <param name="fieldId"></param>
        /// <param name="resourceId"></param>
        /// <param name="data"></param>
        /// <param name="optionId"></param>
        public AddDynamicValueRequest(
            global::System.Guid projectId,
            global::System.Guid setId,
            global::System.Guid descriptorId,
            global::System.Guid fieldId,
            global::System.Guid resourceId,
            string data,
            global::System.Guid optionId)
        {
            this.ProjectId = projectId;
            this.SetId = setId;
            this.DescriptorId = descriptorId;
            this.FieldId = fieldId;
            this.ResourceId = resourceId;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.OptionId = optionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddDynamicValueRequest" /> class.
        /// </summary>
        public AddDynamicValueRequest()
        {
        }
    }
}
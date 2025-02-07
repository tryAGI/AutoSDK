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
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("setId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid SetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("descriptorId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid DescriptorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fieldId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid FieldId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ResourceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("optionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid OptionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
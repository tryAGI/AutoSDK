//HintName: G.Models.Descriptor.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Descriptor
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectIdKey")]
        public string? ProjectIdKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectIDL")]
        public global::System.Guid? ProjectIDL { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createStamp")]
        public global::System.DateTime? CreateStamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createByIDL")]
        public global::System.Guid? CreateByIDL { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("descriptorSetIDL")]
        public global::System.Guid? DescriptorSetIDL { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valuesData")]
        public byte[]? ValuesData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamicValuesData")]
        public byte[]? DynamicValuesData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Descriptor" /> class.
        /// </summary>
        /// <param name="projectIdKey"></param>
        /// <param name="projectId"></param>
        /// <param name="id"></param>
        /// <param name="projectIDL"></param>
        /// <param name="createStamp"></param>
        /// <param name="createByIDL"></param>
        /// <param name="descriptorSetIDL"></param>
        /// <param name="valuesData"></param>
        /// <param name="dynamicValuesData"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public Descriptor(
            string? projectIdKey,
            global::System.Guid? projectId,
            global::System.Guid? id,
            global::System.Guid? projectIDL,
            global::System.DateTime? createStamp,
            global::System.Guid? createByIDL,
            global::System.Guid? descriptorSetIDL,
            byte[]? valuesData,
            byte[]? dynamicValuesData)
        {
            this.ProjectIdKey = projectIdKey;
            this.ProjectId = projectId;
            this.Id = id;
            this.ProjectIDL = projectIDL;
            this.CreateStamp = createStamp;
            this.CreateByIDL = createByIDL;
            this.DescriptorSetIDL = descriptorSetIDL;
            this.ValuesData = valuesData;
            this.DynamicValuesData = dynamicValuesData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Descriptor" /> class.
        /// </summary>
        public Descriptor()
        {
        }
    }
}
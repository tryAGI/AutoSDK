//HintName: G.Models.StartConvertFieldTypeJobRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StartConvertFieldTypeJobRequest
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
        [global::System.Text.Json.Serialization.JsonPropertyName("fieldId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid FieldId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("newFieldType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NewFieldType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartConvertFieldTypeJobRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="setId"></param>
        /// <param name="fieldId"></param>
        /// <param name="newFieldType"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public StartConvertFieldTypeJobRequest(
            global::System.Guid projectId,
            global::System.Guid setId,
            global::System.Guid fieldId,
            int newFieldType)
        {
            this.ProjectId = projectId;
            this.SetId = setId;
            this.FieldId = fieldId;
            this.NewFieldType = newFieldType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartConvertFieldTypeJobRequest" /> class.
        /// </summary>
        public StartConvertFieldTypeJobRequest()
        {
        }
    }
}
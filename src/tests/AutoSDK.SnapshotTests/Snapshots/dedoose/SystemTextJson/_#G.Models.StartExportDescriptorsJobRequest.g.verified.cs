//HintName: G.Models.StartExportDescriptorsJobRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StartExportDescriptorsJobRequest
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
        [global::System.Text.Json.Serialization.JsonPropertyName("descriptorIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> DescriptorIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileExtension")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileExtension { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartExportDescriptorsJobRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="setId"></param>
        /// <param name="descriptorIds"></param>
        /// <param name="fileExtension"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StartExportDescriptorsJobRequest(
            global::System.Guid projectId,
            global::System.Guid setId,
            global::System.Collections.Generic.IList<global::System.Guid> descriptorIds,
            string fileExtension)
        {
            this.ProjectId = projectId;
            this.SetId = setId;
            this.DescriptorIds = descriptorIds ?? throw new global::System.ArgumentNullException(nameof(descriptorIds));
            this.FileExtension = fileExtension ?? throw new global::System.ArgumentNullException(nameof(fileExtension));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartExportDescriptorsJobRequest" /> class.
        /// </summary>
        public StartExportDescriptorsJobRequest()
        {
        }
    }
}
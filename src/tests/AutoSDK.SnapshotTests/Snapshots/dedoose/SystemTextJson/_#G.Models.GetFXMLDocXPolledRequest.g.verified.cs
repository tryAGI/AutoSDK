//HintName: G.Models.GetFXMLDocXPolledRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetFXMLDocXPolledRequest
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
        [global::System.Text.Json.Serialization.JsonPropertyName("fileURL")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileURL { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFXMLDocXPolledRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="fileURL"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetFXMLDocXPolledRequest(
            global::System.Guid projectId,
            string fileURL)
        {
            this.ProjectId = projectId;
            this.FileURL = fileURL ?? throw new global::System.ArgumentNullException(nameof(fileURL));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFXMLDocXPolledRequest" /> class.
        /// </summary>
        public GetFXMLDocXPolledRequest()
        {
        }
    }
}
//HintName: G.Models.StartGetDesDataFromFileJobRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StartGetDesDataFromFileJobRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("localFileURL")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LocalFileURL { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("setId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid SetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartGetDesDataFromFileJobRequest" /> class.
        /// </summary>
        /// <param name="localFileURL"></param>
        /// <param name="setId"></param>
        /// <param name="projectId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StartGetDesDataFromFileJobRequest(
            string localFileURL,
            global::System.Guid setId,
            global::System.Guid projectId)
        {
            this.LocalFileURL = localFileURL ?? throw new global::System.ArgumentNullException(nameof(localFileURL));
            this.SetId = setId;
            this.ProjectId = projectId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartGetDesDataFromFileJobRequest" /> class.
        /// </summary>
        public StartGetDesDataFromFileJobRequest()
        {
        }
    }
}
//HintName: G.Models.StartGetTagsFromImportJobRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StartGetTagsFromImportJobRequest
    {
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
        /// Initializes a new instance of the <see cref="StartGetTagsFromImportJobRequest" /> class.
        /// </summary>
        /// <param name="fileURL"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StartGetTagsFromImportJobRequest(
            string fileURL)
        {
            this.FileURL = fileURL ?? throw new global::System.ArgumentNullException(nameof(fileURL));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartGetTagsFromImportJobRequest" /> class.
        /// </summary>
        public StartGetTagsFromImportJobRequest()
        {
        }
    }
}
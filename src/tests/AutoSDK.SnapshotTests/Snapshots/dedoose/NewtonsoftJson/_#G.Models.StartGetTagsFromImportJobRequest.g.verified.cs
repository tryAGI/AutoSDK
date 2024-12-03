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
        [global::Newtonsoft.Json.JsonProperty("fileURL", Required = global::Newtonsoft.Json.Required.Always)]
        public string FileURL { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartGetTagsFromImportJobRequest" /> class.
        /// </summary>
        /// <param name="fileURL"></param>
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
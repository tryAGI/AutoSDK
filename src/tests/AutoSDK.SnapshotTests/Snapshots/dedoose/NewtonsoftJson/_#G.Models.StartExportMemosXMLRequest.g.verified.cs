//HintName: G.Models.StartExportMemosXMLRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StartExportMemosXMLRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("memoIds", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Guid> MemoIds { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("codeSelection", Required = global::Newtonsoft.Json.Required.Always)]
        public int CodeSelection { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mediaSelection", Required = global::Newtonsoft.Json.Required.Always)]
        public int MediaSelection { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("excerptsSelection", Required = global::Newtonsoft.Json.Required.Always)]
        public int ExcerptsSelection { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("descriptorsSelection", Required = global::Newtonsoft.Json.Required.Always)]
        public int DescriptorsSelection { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("symKey", Required = global::Newtonsoft.Json.Required.Always)]
        public string SymKey { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartExportMemosXMLRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="memoIds"></param>
        /// <param name="codeSelection"></param>
        /// <param name="mediaSelection"></param>
        /// <param name="excerptsSelection"></param>
        /// <param name="descriptorsSelection"></param>
        /// <param name="symKey"></param>
        public StartExportMemosXMLRequest(
            global::System.Guid projectId,
            global::System.Collections.Generic.IList<global::System.Guid> memoIds,
            int codeSelection,
            int mediaSelection,
            int excerptsSelection,
            int descriptorsSelection,
            string symKey)
        {
            this.ProjectId = projectId;
            this.MemoIds = memoIds ?? throw new global::System.ArgumentNullException(nameof(memoIds));
            this.CodeSelection = codeSelection;
            this.MediaSelection = mediaSelection;
            this.ExcerptsSelection = excerptsSelection;
            this.DescriptorsSelection = descriptorsSelection;
            this.SymKey = symKey ?? throw new global::System.ArgumentNullException(nameof(symKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartExportMemosXMLRequest" /> class.
        /// </summary>
        public StartExportMemosXMLRequest()
        {
        }
    }
}
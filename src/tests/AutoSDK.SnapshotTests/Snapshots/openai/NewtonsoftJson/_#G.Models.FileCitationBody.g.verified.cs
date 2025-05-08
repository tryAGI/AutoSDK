//HintName: G.Models.FileCitationBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A citation to a file.
    /// </summary>
    public sealed partial class FileCitationBody
    {
        /// <summary>
        /// The type of the file citation. Always `file_citation`.<br/>
        /// Default Value: file_citation
        /// </summary>
        /// <default>global::G.FileCitationBodyType.FileCitation</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.FileCitationBodyType Type { get; set; } = global::G.FileCitationBodyType.FileCitation;

        /// <summary>
        /// The ID of the file.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string FileId { get; set; } = default!;

        /// <summary>
        /// The index of the file in the list of files.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index", Required = global::Newtonsoft.Json.Required.Always)]
        public int Index { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileCitationBody" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the file citation. Always `file_citation`.<br/>
        /// Default Value: file_citation
        /// </param>
        /// <param name="fileId">
        /// The ID of the file.
        /// </param>
        /// <param name="index">
        /// The index of the file in the list of files.
        /// </param>
        public FileCitationBody(
            string fileId,
            int index,
            global::G.FileCitationBodyType type = global::G.FileCitationBodyType.FileCitation)
        {
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
            this.Index = index;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileCitationBody" /> class.
        /// </summary>
        public FileCitationBody()
        {
        }
    }
}
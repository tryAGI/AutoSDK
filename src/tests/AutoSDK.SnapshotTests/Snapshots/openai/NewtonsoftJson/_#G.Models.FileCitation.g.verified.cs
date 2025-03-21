//HintName: G.Models.FileCitation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A citation to a file.
    /// </summary>
    public sealed partial class FileCitation
    {
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
        /// The type of the file citation. Always `file_citation`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.FileCitationType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileCitation" /> class.
        /// </summary>
        /// <param name="fileId">
        /// The ID of the file.
        /// </param>
        /// <param name="index">
        /// The index of the file in the list of files.
        /// </param>
        /// <param name="type">
        /// The type of the file citation. Always `file_citation`.
        /// </param>
        public FileCitation(
            string fileId,
            int index,
            global::G.FileCitationType type)
        {
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
            this.Index = index;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileCitation" /> class.
        /// </summary>
        public FileCitation()
        {
        }
    }
}
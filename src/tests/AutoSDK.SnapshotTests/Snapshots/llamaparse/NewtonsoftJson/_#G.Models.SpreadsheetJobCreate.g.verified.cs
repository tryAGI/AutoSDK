//HintName: G.Models.SpreadsheetJobCreate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request to create a spreadsheet parsing job
    /// </summary>
    public sealed partial class SpreadsheetJobCreate
    {
        /// <summary>
        /// The ID of the file to parse
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid FileId { get; set; } = default!;

        /// <summary>
        /// Configuration for the parsing job
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config")]
        public global::G.SpreadsheetParsingConfig? Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpreadsheetJobCreate" /> class.
        /// </summary>
        /// <param name="fileId">
        /// The ID of the file to parse
        /// </param>
        /// <param name="config">
        /// Configuration for the parsing job
        /// </param>
        public SpreadsheetJobCreate(
            global::System.Guid fileId,
            global::G.SpreadsheetParsingConfig? config)
        {
            this.FileId = fileId;
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpreadsheetJobCreate" /> class.
        /// </summary>
        public SpreadsheetJobCreate()
        {
        }
    }
}
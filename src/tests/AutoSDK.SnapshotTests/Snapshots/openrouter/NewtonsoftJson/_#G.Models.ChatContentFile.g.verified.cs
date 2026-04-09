//HintName: G.Models.ChatContentFile.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// File content part for document processing
    /// </summary>
    public sealed partial class ChatContentFile
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ChatContentFileTypeJsonConverter))]
        public global::G.ChatContentFileType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ChatContentFileFile File { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatContentFile" /> class.
        /// </summary>
        /// <param name="file"></param>
        /// <param name="type"></param>
        public ChatContentFile(
            global::G.ChatContentFileFile file,
            global::G.ChatContentFileType type)
        {
            this.Type = type;
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatContentFile" /> class.
        /// </summary>
        public ChatContentFile()
        {
        }
    }
}
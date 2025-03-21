//HintName: G.Models.CodeInterpreterTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A tool that runs code.
    /// </summary>
    public sealed partial class CodeInterpreterTool
    {
        /// <summary>
        /// The IDs of the files to run the code on.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> FileIds { get; set; } = default!;

        /// <summary>
        /// The type of the code interpreter tool. Always `code_interpreter`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.CodeInterpreterToolType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeInterpreterTool" /> class.
        /// </summary>
        /// <param name="fileIds">
        /// The IDs of the files to run the code on.
        /// </param>
        /// <param name="type">
        /// The type of the code interpreter tool. Always `code_interpreter`.
        /// </param>
        public CodeInterpreterTool(
            global::System.Collections.Generic.IList<string> fileIds,
            global::G.CodeInterpreterToolType type)
        {
            this.FileIds = fileIds ?? throw new global::System.ArgumentNullException(nameof(fileIds));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeInterpreterTool" /> class.
        /// </summary>
        public CodeInterpreterTool()
        {
        }
    }
}
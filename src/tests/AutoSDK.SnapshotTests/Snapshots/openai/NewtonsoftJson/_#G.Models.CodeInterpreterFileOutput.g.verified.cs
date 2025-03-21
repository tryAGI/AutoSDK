//HintName: G.Models.CodeInterpreterFileOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The output of a code interpreter tool call that is a file.
    /// </summary>
    public sealed partial class CodeInterpreterFileOutput
    {
        /// <summary>
        /// The type of the code interpreter file output. Always `files`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.CodeInterpreterFileOutputType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("files", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CodeInterpreterFileOutputFile> Files { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeInterpreterFileOutput" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the code interpreter file output. Always `files`.
        /// </param>
        /// <param name="files"></param>
        public CodeInterpreterFileOutput(
            global::System.Collections.Generic.IList<global::G.CodeInterpreterFileOutputFile> files,
            global::G.CodeInterpreterFileOutputType type)
        {
            this.Files = files ?? throw new global::System.ArgumentNullException(nameof(files));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeInterpreterFileOutput" /> class.
        /// </summary>
        public CodeInterpreterFileOutput()
        {
        }
    }
}
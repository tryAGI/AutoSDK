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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CodeInterpreterFileOutputTypeJsonConverter))]
        public global::G.CodeInterpreterFileOutputType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.CodeInterpreterFileOutputFile> Files { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeInterpreterFileOutput" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the code interpreter file output. Always `files`.
        /// </param>
        /// <param name="files"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
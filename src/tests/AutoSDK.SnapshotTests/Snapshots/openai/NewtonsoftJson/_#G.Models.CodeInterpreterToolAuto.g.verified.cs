//HintName: G.Models.CodeInterpreterToolAuto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for a code interpreter container. Optionally specify the IDs<br/>
    /// of the files to run the code on.
    /// </summary>
    public sealed partial class CodeInterpreterToolAuto
    {
        /// <summary>
        /// Always `auto`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.CodeInterpreterToolAutoType Type { get; set; }

        /// <summary>
        /// An optional list of uploaded files to make available to your code.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_ids")]
        public global::System.Collections.Generic.IList<string>? FileIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeInterpreterToolAuto" /> class.
        /// </summary>
        /// <param name="type">
        /// Always `auto`.
        /// </param>
        /// <param name="fileIds">
        /// An optional list of uploaded files to make available to your code.
        /// </param>
        public CodeInterpreterToolAuto(
            global::G.CodeInterpreterToolAutoType type,
            global::System.Collections.Generic.IList<string>? fileIds)
        {
            this.Type = type;
            this.FileIds = fileIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeInterpreterToolAuto" /> class.
        /// </summary>
        public CodeInterpreterToolAuto()
        {
        }
    }
}
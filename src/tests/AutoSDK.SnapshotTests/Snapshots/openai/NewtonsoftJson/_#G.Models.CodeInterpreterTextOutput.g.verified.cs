//HintName: G.Models.CodeInterpreterTextOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The output of a code interpreter tool call that is text.
    /// </summary>
    public sealed partial class CodeInterpreterTextOutput
    {
        /// <summary>
        /// The logs of the code interpreter tool call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logs", Required = global::Newtonsoft.Json.Required.Always)]
        public string Logs { get; set; } = default!;

        /// <summary>
        /// The type of the code interpreter text output. Always `logs`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.CodeInterpreterTextOutputType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeInterpreterTextOutput" /> class.
        /// </summary>
        /// <param name="logs">
        /// The logs of the code interpreter tool call.
        /// </param>
        /// <param name="type">
        /// The type of the code interpreter text output. Always `logs`.
        /// </param>
        public CodeInterpreterTextOutput(
            string logs,
            global::G.CodeInterpreterTextOutputType type)
        {
            this.Logs = logs ?? throw new global::System.ArgumentNullException(nameof(logs));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeInterpreterTextOutput" /> class.
        /// </summary>
        public CodeInterpreterTextOutput()
        {
        }
    }
}
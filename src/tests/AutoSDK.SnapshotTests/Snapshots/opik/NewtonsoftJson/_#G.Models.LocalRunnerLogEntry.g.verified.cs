//HintName: G.Models.LocalRunnerLogEntry.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LocalRunnerLogEntry
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stream", Required = global::Newtonsoft.Json.Required.Always)]
        public string Stream { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalRunnerLogEntry" /> class.
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="text"></param>
        public LocalRunnerLogEntry(
            string stream,
            string text)
        {
            this.Stream = stream ?? throw new global::System.ArgumentNullException(nameof(stream));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalRunnerLogEntry" /> class.
        /// </summary>
        public LocalRunnerLogEntry()
        {
        }
    }
}
//HintName: G.Models.TuningExample.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A single example for tuning.
    /// </summary>
    public sealed partial class TuningExample
    {
        /// <summary>
        /// Optional. Text model input.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("textInput")]
        public string? TextInput { get; set; }

        /// <summary>
        /// Required. The expected model output.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output")]
        public string? Output { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TuningExample" /> class.
        /// </summary>
        /// <param name="textInput">
        /// Optional. Text model input.
        /// </param>
        /// <param name="output">
        /// Required. The expected model output.
        /// </param>
        public TuningExample(
            string? textInput,
            string? output)
        {
            this.TextInput = textInput;
            this.Output = output;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TuningExample" /> class.
        /// </summary>
        public TuningExample()
        {
        }
    }
}
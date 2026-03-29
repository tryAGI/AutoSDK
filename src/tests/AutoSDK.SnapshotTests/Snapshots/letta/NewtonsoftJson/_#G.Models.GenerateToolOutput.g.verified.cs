//HintName: G.Models.GenerateToolOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateToolOutput
    {
        /// <summary>
        /// Generated tool
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Tool Tool { get; set; } = default!;

        /// <summary>
        /// Sample arguments for the tool
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sample_args", Required = global::Newtonsoft.Json.Required.Always)]
        public object SampleArgs { get; set; } = default!;

        /// <summary>
        /// Response from the assistant
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response", Required = global::Newtonsoft.Json.Required.Always)]
        public string Response { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateToolOutput" /> class.
        /// </summary>
        /// <param name="tool">
        /// Generated tool
        /// </param>
        /// <param name="sampleArgs">
        /// Sample arguments for the tool
        /// </param>
        /// <param name="response">
        /// Response from the assistant
        /// </param>
        public GenerateToolOutput(
            global::G.Tool tool,
            object sampleArgs,
            string response)
        {
            this.Tool = tool ?? throw new global::System.ArgumentNullException(nameof(tool));
            this.SampleArgs = sampleArgs ?? throw new global::System.ArgumentNullException(nameof(sampleArgs));
            this.Response = response ?? throw new global::System.ArgumentNullException(nameof(response));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateToolOutput" /> class.
        /// </summary>
        public GenerateToolOutput()
        {
        }
    }
}
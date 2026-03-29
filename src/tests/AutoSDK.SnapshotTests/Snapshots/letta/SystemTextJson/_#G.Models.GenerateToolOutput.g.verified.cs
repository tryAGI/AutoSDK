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
        [global::System.Text.Json.Serialization.JsonPropertyName("tool")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Tool Tool { get; set; }

        /// <summary>
        /// Sample arguments for the tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_args")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object SampleArgs { get; set; }

        /// <summary>
        /// Response from the assistant
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Response { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
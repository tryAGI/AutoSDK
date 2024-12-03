//HintName: G.Models.CreateTranscriptionResponseJson.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents a transcription response returned by model, based on the provided input.
    /// </summary>
    public sealed partial class CreateTranscriptionResponseJson
    {
        /// <summary>
        /// The transcribed text.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTranscriptionResponseJson" /> class.
        /// </summary>
        /// <param name="text">
        /// The transcribed text.
        /// </param>
        public CreateTranscriptionResponseJson(
            string text)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTranscriptionResponseJson" /> class.
        /// </summary>
        public CreateTranscriptionResponseJson()
        {
        }
    }
}
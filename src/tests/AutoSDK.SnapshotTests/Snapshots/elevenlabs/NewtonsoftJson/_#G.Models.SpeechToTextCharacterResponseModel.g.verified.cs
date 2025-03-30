//HintName: G.Models.SpeechToTextCharacterResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpeechToTextCharacterResponseModel
    {
        /// <summary>
        /// The character that was transcribed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// The start time of the character in seconds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start")]
        public double? Start { get; set; }

        /// <summary>
        /// The end time of the character in seconds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end")]
        public double? End { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechToTextCharacterResponseModel" /> class.
        /// </summary>
        /// <param name="text">
        /// The character that was transcribed.
        /// </param>
        /// <param name="start">
        /// The start time of the character in seconds.
        /// </param>
        /// <param name="end">
        /// The end time of the character in seconds.
        /// </param>
        public SpeechToTextCharacterResponseModel(
            string text,
            double? start,
            double? end)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Start = start;
            this.End = end;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechToTextCharacterResponseModel" /> class.
        /// </summary>
        public SpeechToTextCharacterResponseModel()
        {
        }
    }
}
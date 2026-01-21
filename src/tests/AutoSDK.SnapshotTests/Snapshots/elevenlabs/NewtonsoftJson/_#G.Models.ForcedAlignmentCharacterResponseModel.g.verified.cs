//HintName: G.Models.ForcedAlignmentCharacterResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Model representing a single character with its timing information from the aligner.<br/>
    /// Example: {"end":0.02,"start":0,"text":"H"}
    /// </summary>
    public sealed partial class ForcedAlignmentCharacterResponseModel
    {
        /// <summary>
        /// The character that was transcribed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// The start time of the character in seconds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start", Required = global::Newtonsoft.Json.Required.Always)]
        public double Start { get; set; } = default!;

        /// <summary>
        /// The end time of the character in seconds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end", Required = global::Newtonsoft.Json.Required.Always)]
        public double End { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ForcedAlignmentCharacterResponseModel" /> class.
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
        public ForcedAlignmentCharacterResponseModel(
            string text,
            double start,
            double end)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Start = start;
            this.End = end;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ForcedAlignmentCharacterResponseModel" /> class.
        /// </summary>
        public ForcedAlignmentCharacterResponseModel()
        {
        }
    }
}
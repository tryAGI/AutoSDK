//HintName: G.Models.ForcedAlignmentWordResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Model representing a single word with its timing information from the aligner.
    /// </summary>
    public sealed partial class ForcedAlignmentWordResponseModel
    {
        /// <summary>
        /// The word that was transcribed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// The start time of the word in seconds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start", Required = global::Newtonsoft.Json.Required.Always)]
        public double Start { get; set; } = default!;

        /// <summary>
        /// The end time of the word in seconds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end", Required = global::Newtonsoft.Json.Required.Always)]
        public double End { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ForcedAlignmentWordResponseModel" /> class.
        /// </summary>
        /// <param name="text">
        /// The word that was transcribed.
        /// </param>
        /// <param name="start">
        /// The start time of the word in seconds.
        /// </param>
        /// <param name="end">
        /// The end time of the word in seconds.
        /// </param>
        public ForcedAlignmentWordResponseModel(
            string text,
            double start,
            double end)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Start = start;
            this.End = end;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ForcedAlignmentWordResponseModel" /> class.
        /// </summary>
        public ForcedAlignmentWordResponseModel()
        {
        }
    }
}
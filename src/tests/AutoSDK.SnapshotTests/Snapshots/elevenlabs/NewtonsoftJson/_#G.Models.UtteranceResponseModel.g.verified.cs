//HintName: G.Models.UtteranceResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"end":1,"start":0}
    /// </summary>
    public sealed partial class UtteranceResponseModel
    {
        /// <summary>
        /// The start time of the utterance in seconds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start", Required = global::Newtonsoft.Json.Required.Always)]
        public double Start { get; set; } = default!;

        /// <summary>
        /// The end time of the utterance in seconds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end", Required = global::Newtonsoft.Json.Required.Always)]
        public double End { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UtteranceResponseModel" /> class.
        /// </summary>
        /// <param name="start">
        /// The start time of the utterance in seconds.
        /// </param>
        /// <param name="end">
        /// The end time of the utterance in seconds.
        /// </param>
        public UtteranceResponseModel(
            double start,
            double end)
        {
            this.Start = start;
            this.End = end;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UtteranceResponseModel" /> class.
        /// </summary>
        public UtteranceResponseModel()
        {
        }
    }
}
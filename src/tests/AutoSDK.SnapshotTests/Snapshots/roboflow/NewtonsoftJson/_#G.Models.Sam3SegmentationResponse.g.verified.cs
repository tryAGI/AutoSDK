//HintName: G.Models.Sam3SegmentationResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Sam3SegmentationResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_results", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Sam3PromptResult> PromptResults { get; set; } = default!;

        /// <summary>
        /// The time in seconds it took to produce the segmentation including preprocessing
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("time", Required = global::Newtonsoft.Json.Required.Always)]
        public double Time { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Sam3SegmentationResponse" /> class.
        /// </summary>
        /// <param name="promptResults"></param>
        /// <param name="time">
        /// The time in seconds it took to produce the segmentation including preprocessing
        /// </param>
        public Sam3SegmentationResponse(
            global::System.Collections.Generic.IList<global::G.Sam3PromptResult> promptResults,
            double time)
        {
            this.PromptResults = promptResults ?? throw new global::System.ArgumentNullException(nameof(promptResults));
            this.Time = time;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Sam3SegmentationResponse" /> class.
        /// </summary>
        public Sam3SegmentationResponse()
        {
        }
    }
}
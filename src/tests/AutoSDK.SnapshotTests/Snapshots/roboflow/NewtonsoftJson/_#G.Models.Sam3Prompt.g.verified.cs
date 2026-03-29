//HintName: G.Models.Sam3Prompt.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Unified prompt that can contain text and/or geometry.<br/>
    /// Absolute pixel coordinates are used for boxes. Labels accept 0/1 or booleans.
    /// </summary>
    public sealed partial class Sam3Prompt
    {
        /// <summary>
        /// Optional hint: 'text' or 'visual'
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Score threshold for this prompt's outputs. Overrides request-level threshold if set.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_prob_thresh")]
        public double? OutputProbThresh { get; set; }

        /// <summary>
        /// Absolute pixel boxes as either XYWH or XYXY entries
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("boxes")]
        public global::System.Collections.Generic.IList<global::G.AnyOf<global::G.Box, global::G.BoxXYXY>>? Boxes { get; set; }

        /// <summary>
        /// List of 0/1 or booleans for boxes
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("box_labels")]
        public global::System.Collections.Generic.IList<global::G.AnyOf<int?, bool?>>? BoxLabels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Sam3Prompt" /> class.
        /// </summary>
        /// <param name="type">
        /// Optional hint: 'text' or 'visual'
        /// </param>
        /// <param name="text"></param>
        /// <param name="outputProbThresh">
        /// Score threshold for this prompt's outputs. Overrides request-level threshold if set.
        /// </param>
        /// <param name="boxes">
        /// Absolute pixel boxes as either XYWH or XYXY entries
        /// </param>
        /// <param name="boxLabels">
        /// List of 0/1 or booleans for boxes
        /// </param>
        public Sam3Prompt(
            string? type,
            string? text,
            double? outputProbThresh,
            global::System.Collections.Generic.IList<global::G.AnyOf<global::G.Box, global::G.BoxXYXY>>? boxes,
            global::System.Collections.Generic.IList<global::G.AnyOf<int?, bool?>>? boxLabels)
        {
            this.Type = type;
            this.Text = text;
            this.OutputProbThresh = outputProbThresh;
            this.Boxes = boxes;
            this.BoxLabels = boxLabels;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Sam3Prompt" /> class.
        /// </summary>
        public Sam3Prompt()
        {
        }
    }
}
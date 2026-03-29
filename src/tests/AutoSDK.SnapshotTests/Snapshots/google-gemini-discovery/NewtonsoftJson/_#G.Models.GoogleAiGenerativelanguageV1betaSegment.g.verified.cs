//HintName: G.Models.GoogleAiGenerativelanguageV1betaSegment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Segment of the content.
    /// </summary>
    public sealed partial class GoogleAiGenerativelanguageV1betaSegment
    {
        /// <summary>
        /// The index of a Part object within its parent Content object.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("partIndex")]
        public int? PartIndex { get; set; }

        /// <summary>
        /// Start index in the given Part, measured in bytes. Offset from the start of the Part, inclusive, starting at zero.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("startIndex")]
        public int? StartIndex { get; set; }

        /// <summary>
        /// End index in the given Part, measured in bytes. Offset from the start of the Part, exclusive, starting at zero.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endIndex")]
        public int? EndIndex { get; set; }

        /// <summary>
        /// The text corresponding to the segment from the response.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleAiGenerativelanguageV1betaSegment" /> class.
        /// </summary>
        /// <param name="partIndex">
        /// The index of a Part object within its parent Content object.
        /// </param>
        /// <param name="startIndex">
        /// Start index in the given Part, measured in bytes. Offset from the start of the Part, inclusive, starting at zero.
        /// </param>
        /// <param name="endIndex">
        /// End index in the given Part, measured in bytes. Offset from the start of the Part, exclusive, starting at zero.
        /// </param>
        /// <param name="text">
        /// The text corresponding to the segment from the response.
        /// </param>
        public GoogleAiGenerativelanguageV1betaSegment(
            int? partIndex,
            int? startIndex,
            int? endIndex,
            string? text)
        {
            this.PartIndex = partIndex;
            this.StartIndex = startIndex;
            this.EndIndex = endIndex;
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleAiGenerativelanguageV1betaSegment" /> class.
        /// </summary>
        public GoogleAiGenerativelanguageV1betaSegment()
        {
        }
    }
}
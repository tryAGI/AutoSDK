//HintName: G.Models.PullsCreateReviewRequestComment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PullsCreateReviewRequestComment
    {
        /// <summary>
        /// The relative path to the file that necessitates a review comment.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("path", Required = global::Newtonsoft.Json.Required.Always)]
        public string Path { get; set; } = default!;

        /// <summary>
        /// The position in the diff where you want to add a review comment. Note this value is not the same as the line number in the file. The `position` value equals the number of lines down from the first "@@" hunk header in the file you want to add a comment. The line just below the "@@" line is position 1, the next line is position 2, and so on. The position in the diff continues to increase through lines of whitespace and additional hunks until the beginning of a new file.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("position")]
        public int Position { get; set; }

        /// <summary>
        /// Text of the review comment.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body", Required = global::Newtonsoft.Json.Required.Always)]
        public string Body { get; set; } = default!;

        /// <summary>
        /// Example: 28
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("line")]
        public int Line { get; set; }

        /// <summary>
        /// Example: RIGHT
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("side")]
        public string? Side { get; set; }

        /// <summary>
        /// Example: 26
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_line")]
        public int StartLine { get; set; }

        /// <summary>
        /// Example: LEFT
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_side")]
        public string? StartSide { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
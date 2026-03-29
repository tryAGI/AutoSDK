//HintName: G.Models.Chapter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Chapter
    {
        /// <summary>
        /// The auto-generated title for the chapter
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// An auto-generated paragraph-style, short summary of the chapter
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// The start time of the chapter in the audio file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_time")]
        public double? StartTime { get; set; }

        /// <summary>
        /// The end time of the chapter in the audio file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_time")]
        public double? EndTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Chapter" /> class.
        /// </summary>
        /// <param name="title">
        /// The auto-generated title for the chapter
        /// </param>
        /// <param name="summary">
        /// An auto-generated paragraph-style, short summary of the chapter
        /// </param>
        /// <param name="startTime">
        /// The start time of the chapter in the audio file
        /// </param>
        /// <param name="endTime">
        /// The end time of the chapter in the audio file
        /// </param>
        public Chapter(
            string? title,
            string? summary,
            double? startTime,
            double? endTime)
        {
            this.Title = title;
            this.Summary = summary;
            this.StartTime = startTime;
            this.EndTime = endTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Chapter" /> class.
        /// </summary>
        public Chapter()
        {
        }
    }
}
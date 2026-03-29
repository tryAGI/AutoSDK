//HintName: G.Models.SearchItemClipsItems.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchItemClipsItems
    {
        /// <summary>
        /// &lt;Info&gt;<br/>
        ///   Marengo 3.0 and newer versions do not return this field. Use the `rank` field instead.<br/>
        /// &lt;/Info&gt;<br/>
        /// A quantitative value determined by the AI model representing the level of confidence that the results match your search terms.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("score")]
        public double? Score { get; set; }

        /// <summary>
        /// The start time of the matching video clip, expressed in seconds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start")]
        public double? Start { get; set; }

        /// <summary>
        /// The end time of the matching video clip, expressed in seconds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end")]
        public double? End { get; set; }

        /// <summary>
        /// &lt;Info&gt;<br/>
        ///   Marengo 3.0 and newer versions do not return this field. Use the `rank` field instead.<br/>
        /// &lt;/Info&gt;<br/>
        /// A qualitative indicator based on the value of the `score` field. This field can take one of the following values:<br/>
        /// - `high`<br/>
        /// - `medium`<br/>
        /// - `low`<br/>
        /// - `extremely low`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("confidence")]
        public string? Confidence { get; set; }

        /// <summary>
        /// &lt;Info&gt;<br/>
        ///   Only Marengo 3.0 and newer versions return this field. Earlier versions return `score` and `confidence` instead.<br/>
        /// &lt;/Info&gt;<br/>
        /// The relevance ranking assigned by the model. Lower numbers indicate higher relevance, starting with 1 for the most relevant result.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rank")]
        public int? Rank { get; set; }

        /// <summary>
        /// If thumbnail generation has been enabled for this index, the platform returns a string representing the URL of the thumbnail. Note that the URL expires in one hour.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("thumbnail_url")]
        public string? ThumbnailUrl { get; set; }

        /// <summary>
        /// A transcription of the spoken words that are captured in the clip.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transcription")]
        public string? Transcription { get; set; }

        /// <summary>
        /// A string representing the unique identifier of the video for the corresponding clip.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("video_id")]
        public string? VideoId { get; set; }

        /// <summary>
        /// Metadata that helps you categorize your videos. You can specify a list of keys and values. Keys must be of type `string`, and values can be of the following types: `string`, `integer`, `float` or `boolean`.<br/>
        /// **Example**:<br/>
        /// ```JSON<br/>
        /// "user_metadata": {<br/>
        ///   "category": "recentlyAdded",<br/>
        ///   "batchNumber": 5,<br/>
        ///   "rating": 9.3,<br/>
        ///   "needsReview": true<br/>
        /// }<br/>
        /// ```<br/>
        /// &lt;Note title="Notes"&gt;<br/>
        /// -  If you want to store other types of data such as objects or arrays,  you must convert your data into string values.<br/>
        /// - You cannot override the following system-generated metadata fields:<br/>
        ///   - `duration`<br/>
        ///   - `filename`<br/>
        ///   - `fps`<br/>
        ///   - `height`<br/>
        ///   - `model_names`<br/>
        ///   - `size`<br/>
        ///   - `video_title`<br/>
        ///   - `width`<br/>
        /// &lt;/Note&gt;
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_metadata")]
        public global::G.UserMetadata? UserMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchItemClipsItems" /> class.
        /// </summary>
        /// <param name="score">
        /// &lt;Info&gt;<br/>
        ///   Marengo 3.0 and newer versions do not return this field. Use the `rank` field instead.<br/>
        /// &lt;/Info&gt;<br/>
        /// A quantitative value determined by the AI model representing the level of confidence that the results match your search terms.
        /// </param>
        /// <param name="start">
        /// The start time of the matching video clip, expressed in seconds.
        /// </param>
        /// <param name="end">
        /// The end time of the matching video clip, expressed in seconds.
        /// </param>
        /// <param name="confidence">
        /// &lt;Info&gt;<br/>
        ///   Marengo 3.0 and newer versions do not return this field. Use the `rank` field instead.<br/>
        /// &lt;/Info&gt;<br/>
        /// A qualitative indicator based on the value of the `score` field. This field can take one of the following values:<br/>
        /// - `high`<br/>
        /// - `medium`<br/>
        /// - `low`<br/>
        /// - `extremely low`
        /// </param>
        /// <param name="rank">
        /// &lt;Info&gt;<br/>
        ///   Only Marengo 3.0 and newer versions return this field. Earlier versions return `score` and `confidence` instead.<br/>
        /// &lt;/Info&gt;<br/>
        /// The relevance ranking assigned by the model. Lower numbers indicate higher relevance, starting with 1 for the most relevant result.
        /// </param>
        /// <param name="thumbnailUrl">
        /// If thumbnail generation has been enabled for this index, the platform returns a string representing the URL of the thumbnail. Note that the URL expires in one hour.
        /// </param>
        /// <param name="transcription">
        /// A transcription of the spoken words that are captured in the clip.
        /// </param>
        /// <param name="videoId">
        /// A string representing the unique identifier of the video for the corresponding clip.
        /// </param>
        /// <param name="userMetadata">
        /// Metadata that helps you categorize your videos. You can specify a list of keys and values. Keys must be of type `string`, and values can be of the following types: `string`, `integer`, `float` or `boolean`.<br/>
        /// **Example**:<br/>
        /// ```JSON<br/>
        /// "user_metadata": {<br/>
        ///   "category": "recentlyAdded",<br/>
        ///   "batchNumber": 5,<br/>
        ///   "rating": 9.3,<br/>
        ///   "needsReview": true<br/>
        /// }<br/>
        /// ```<br/>
        /// &lt;Note title="Notes"&gt;<br/>
        /// -  If you want to store other types of data such as objects or arrays,  you must convert your data into string values.<br/>
        /// - You cannot override the following system-generated metadata fields:<br/>
        ///   - `duration`<br/>
        ///   - `filename`<br/>
        ///   - `fps`<br/>
        ///   - `height`<br/>
        ///   - `model_names`<br/>
        ///   - `size`<br/>
        ///   - `video_title`<br/>
        ///   - `width`<br/>
        /// &lt;/Note&gt;
        /// </param>
        public SearchItemClipsItems(
            double? score,
            double? start,
            double? end,
            string? confidence,
            int? rank,
            string? thumbnailUrl,
            string? transcription,
            string? videoId,
            global::G.UserMetadata? userMetadata)
        {
            this.Score = score;
            this.Start = start;
            this.End = end;
            this.Confidence = confidence;
            this.Rank = rank;
            this.ThumbnailUrl = thumbnailUrl;
            this.Transcription = transcription;
            this.VideoId = videoId;
            this.UserMetadata = userMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchItemClipsItems" /> class.
        /// </summary>
        public SearchItemClipsItems()
        {
        }
    }
}
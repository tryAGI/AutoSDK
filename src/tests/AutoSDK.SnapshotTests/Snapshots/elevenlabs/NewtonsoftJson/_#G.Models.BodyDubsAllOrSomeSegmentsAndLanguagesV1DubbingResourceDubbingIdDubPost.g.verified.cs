//HintName: G.Models.BodyDubsAllOrSomeSegmentsAndLanguagesV1DubbingResourceDubbingIdDubPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyDubsAllOrSomeSegmentsAndLanguagesV1DubbingResourceDubbingIdDubPost
    {
        /// <summary>
        /// Dub only this list of segments.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("segments", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Segments { get; set; } = default!;

        /// <summary>
        /// Dub only these languages for each segment.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("languages", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string>? Languages { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyDubsAllOrSomeSegmentsAndLanguagesV1DubbingResourceDubbingIdDubPost" /> class.
        /// </summary>
        /// <param name="segments">
        /// Dub only this list of segments.
        /// </param>
        /// <param name="languages">
        /// Dub only these languages for each segment.
        /// </param>
        public BodyDubsAllOrSomeSegmentsAndLanguagesV1DubbingResourceDubbingIdDubPost(
            global::System.Collections.Generic.IList<string> segments,
            global::System.Collections.Generic.IList<string>? languages)
        {
            this.Segments = segments ?? throw new global::System.ArgumentNullException(nameof(segments));
            this.Languages = languages ?? throw new global::System.ArgumentNullException(nameof(languages));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyDubsAllOrSomeSegmentsAndLanguagesV1DubbingResourceDubbingIdDubPost" /> class.
        /// </summary>
        public BodyDubsAllOrSomeSegmentsAndLanguagesV1DubbingResourceDubbingIdDubPost()
        {
        }
    }
}
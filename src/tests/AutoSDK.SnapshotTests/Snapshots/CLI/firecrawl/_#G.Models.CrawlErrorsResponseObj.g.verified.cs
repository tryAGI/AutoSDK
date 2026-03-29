//HintName: G.Models.CrawlErrorsResponseObj.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CrawlErrorsResponseObj
    {
        /// <summary>
        /// Errored scrape jobs and error details
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        public global::System.Collections.Generic.IList<global::G.CrawlErrorsResponseObjError>? Errors { get; set; }

        /// <summary>
        /// List of URLs that were attempted in scraping but were blocked by robots.txt
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("robotsBlocked")]
        public global::System.Collections.Generic.IList<string>? RobotsBlocked { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CrawlErrorsResponseObj" /> class.
        /// </summary>
        /// <param name="errors">
        /// Errored scrape jobs and error details
        /// </param>
        /// <param name="robotsBlocked">
        /// List of URLs that were attempted in scraping but were blocked by robots.txt
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CrawlErrorsResponseObj(
            global::System.Collections.Generic.IList<global::G.CrawlErrorsResponseObjError>? errors,
            global::System.Collections.Generic.IList<string>? robotsBlocked)
        {
            this.Errors = errors;
            this.RobotsBlocked = robotsBlocked;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CrawlErrorsResponseObj" /> class.
        /// </summary>
        public CrawlErrorsResponseObj()
        {
        }
    }
}
//HintName: G.Models.PostChapterizationMessageData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostChapterizationMessageData
    {
        /// <summary>
        /// The chapters
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("results", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.PostChapterizationResult> Results { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostChapterizationMessageData" /> class.
        /// </summary>
        /// <param name="results">
        /// The chapters
        /// </param>
        public PostChapterizationMessageData(
            global::System.Collections.Generic.IList<global::G.PostChapterizationResult> results)
        {
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostChapterizationMessageData" /> class.
        /// </summary>
        public PostChapterizationMessageData()
        {
        }
    }
}
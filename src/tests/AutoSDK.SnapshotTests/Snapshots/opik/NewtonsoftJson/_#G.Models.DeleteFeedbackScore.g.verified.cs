//HintName: G.Models.DeleteFeedbackScore.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteFeedbackScore
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("author")]
        public string? Author { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteFeedbackScore" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="author"></param>
        public DeleteFeedbackScore(
            string name,
            string? author)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Author = author;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteFeedbackScore" /> class.
        /// </summary>
        public DeleteFeedbackScore()
        {
        }
    }
}
//HintName: G.Models.DeleteThreadFeedbackScores.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteThreadFeedbackScores
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("thread_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ThreadId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("names", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Names { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="DeleteThreadFeedbackScores" /> class.
        /// </summary>
        /// <param name="projectName"></param>
        /// <param name="threadId"></param>
        /// <param name="names"></param>
        /// <param name="author"></param>
        public DeleteThreadFeedbackScores(
            string projectName,
            string threadId,
            global::System.Collections.Generic.IList<string> names,
            string? author)
        {
            this.ProjectName = projectName ?? throw new global::System.ArgumentNullException(nameof(projectName));
            this.ThreadId = threadId ?? throw new global::System.ArgumentNullException(nameof(threadId));
            this.Names = names ?? throw new global::System.ArgumentNullException(nameof(names));
            this.Author = author;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteThreadFeedbackScores" /> class.
        /// </summary>
        public DeleteThreadFeedbackScores()
        {
        }
    }
}
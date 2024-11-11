//HintName: G.Models.RepositoryRuleMergeQueue.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Merges must be performed via a merge queue.
    /// </summary>
    public sealed partial class RepositoryRuleMergeQueue
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RepositoryRuleMergeQueueType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters")]
        public global::G.RepositoryRuleMergeQueueParameters? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleMergeQueue" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="parameters"></param>
        public RepositoryRuleMergeQueue(
            global::G.RepositoryRuleMergeQueueType type,
            global::G.RepositoryRuleMergeQueueParameters? parameters)
        {
            this.Type = type;
            this.Parameters = parameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleMergeQueue" /> class.
        /// </summary>
        public RepositoryRuleMergeQueue()
        {
        }
    }
}
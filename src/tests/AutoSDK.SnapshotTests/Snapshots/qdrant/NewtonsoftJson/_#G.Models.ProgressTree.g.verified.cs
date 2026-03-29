//HintName: G.Models.ProgressTree.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProgressTree
    {
        /// <summary>
        /// Name of the operation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// When the operation started.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("started_at")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// When the operation finished.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("finished_at")]
        public global::System.DateTime? FinishedAt { get; set; }

        /// <summary>
        /// For finished operations, how long they took, in seconds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration_sec")]
        public double? DurationSec { get; set; }

        /// <summary>
        /// Number of completed units of work, if applicable.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("done")]
        public int? Done { get; set; }

        /// <summary>
        /// Total number of units of work, if applicable and known.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total")]
        public int? Total { get; set; }

        /// <summary>
        /// Child operations.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("children")]
        public global::System.Collections.Generic.IList<global::G.ProgressTree>? Children { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProgressTree" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the operation.
        /// </param>
        /// <param name="startedAt">
        /// When the operation started.
        /// </param>
        /// <param name="finishedAt">
        /// When the operation finished.
        /// </param>
        /// <param name="durationSec">
        /// For finished operations, how long they took, in seconds.
        /// </param>
        /// <param name="done">
        /// Number of completed units of work, if applicable.
        /// </param>
        /// <param name="total">
        /// Total number of units of work, if applicable and known.
        /// </param>
        /// <param name="children">
        /// Child operations.
        /// </param>
        public ProgressTree(
            string name,
            global::System.DateTime? startedAt,
            global::System.DateTime? finishedAt,
            double? durationSec,
            int? done,
            int? total,
            global::System.Collections.Generic.IList<global::G.ProgressTree>? children)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.StartedAt = startedAt;
            this.FinishedAt = finishedAt;
            this.DurationSec = durationSec;
            this.Done = done;
            this.Total = total;
            this.Children = children;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProgressTree" /> class.
        /// </summary>
        public ProgressTree()
        {
        }
    }
}
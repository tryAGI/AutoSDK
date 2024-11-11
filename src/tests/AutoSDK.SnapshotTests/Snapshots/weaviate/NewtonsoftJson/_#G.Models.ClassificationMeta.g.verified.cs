//HintName: G.Models.ClassificationMeta.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Additional information to a specific classification
    /// </summary>
    public sealed partial class ClassificationMeta
    {
        /// <summary>
        /// time when this classification was started
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("started")]
        public global::System.DateTime? Started { get; set; }

        /// <summary>
        /// time when this classification finished
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completed")]
        public global::System.DateTime? Completed { get; set; }

        /// <summary>
        /// number of objects which were taken into consideration for classification<br/>
        /// Example: 147
        /// </summary>
        /// <example>147</example>
        [global::Newtonsoft.Json.JsonProperty("count")]
        public int? Count { get; set; }

        /// <summary>
        /// number of objects successfully classified<br/>
        /// Example: 140
        /// </summary>
        /// <example>140</example>
        [global::Newtonsoft.Json.JsonProperty("countSucceeded")]
        public int? CountSucceeded { get; set; }

        /// <summary>
        /// number of objects which could not be classified - see error message for details<br/>
        /// Example: 7
        /// </summary>
        /// <example>7</example>
        [global::Newtonsoft.Json.JsonProperty("countFailed")]
        public int? CountFailed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassificationMeta" /> class.
        /// </summary>
        /// <param name="started">
        /// time when this classification was started
        /// </param>
        /// <param name="completed">
        /// time when this classification finished
        /// </param>
        /// <param name="count">
        /// number of objects which were taken into consideration for classification<br/>
        /// Example: 147
        /// </param>
        /// <param name="countSucceeded">
        /// number of objects successfully classified<br/>
        /// Example: 140
        /// </param>
        /// <param name="countFailed">
        /// number of objects which could not be classified - see error message for details<br/>
        /// Example: 7
        /// </param>
        public ClassificationMeta(
            global::System.DateTime? started,
            global::System.DateTime? completed,
            int? count,
            int? countSucceeded,
            int? countFailed)
        {
            this.Started = started;
            this.Completed = completed;
            this.Count = count;
            this.CountSucceeded = countSucceeded;
            this.CountFailed = countFailed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassificationMeta" /> class.
        /// </summary>
        public ClassificationMeta()
        {
        }
    }
}
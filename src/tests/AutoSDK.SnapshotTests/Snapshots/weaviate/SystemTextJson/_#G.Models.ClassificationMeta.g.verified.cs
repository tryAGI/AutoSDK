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
        /// time when this classification was started<br/>
        /// Example: 2017-07-21T17:32:28.0000000+00:00
        /// </summary>
        /// <example>2017-07-21T17:32:28.0000000+00:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("started")]
        public global::System.DateTime? Started { get; set; }

        /// <summary>
        /// time when this classification finished<br/>
        /// Example: 2017-07-21T17:32:28.0000000+00:00
        /// </summary>
        /// <example>2017-07-21T17:32:28.0000000+00:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed")]
        public global::System.DateTime? Completed { get; set; }

        /// <summary>
        /// number of objects which were taken into consideration for classification<br/>
        /// Example: 147
        /// </summary>
        /// <example>147</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        public int? Count { get; set; }

        /// <summary>
        /// number of objects successfully classified<br/>
        /// Example: 140
        /// </summary>
        /// <example>140</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("countSucceeded")]
        public int? CountSucceeded { get; set; }

        /// <summary>
        /// number of objects which could not be classified - see error message for details<br/>
        /// Example: 7
        /// </summary>
        /// <example>7</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("countFailed")]
        public int? CountFailed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassificationMeta" /> class.
        /// </summary>
        /// <param name="started">
        /// time when this classification was started<br/>
        /// Example: 2017-07-21T17:32:28.0000000+00:00
        /// </param>
        /// <param name="completed">
        /// time when this classification finished<br/>
        /// Example: 2017-07-21T17:32:28.0000000+00:00
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
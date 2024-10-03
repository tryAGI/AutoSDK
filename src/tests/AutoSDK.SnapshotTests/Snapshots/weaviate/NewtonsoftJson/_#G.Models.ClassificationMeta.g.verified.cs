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
        [global::Newtonsoft.Json.JsonProperty("count")]
        public int? Count { get; set; }

        /// <summary>
        /// number of objects successfully classified<br/>
        /// Example: 140
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("countSucceeded")]
        public int? CountSucceeded { get; set; }

        /// <summary>
        /// number of objects which could not be classified - see error message for details<br/>
        /// Example: 7
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("countFailed")]
        public int? CountFailed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
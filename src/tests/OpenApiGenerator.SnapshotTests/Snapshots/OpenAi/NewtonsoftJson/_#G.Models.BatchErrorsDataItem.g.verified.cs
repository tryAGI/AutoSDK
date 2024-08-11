//HintName: G.Models.BatchErrorsDataItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchErrorsDataItem
    {
        /// <summary>
        /// An error code identifying the error type.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code")]
        public string? Code { get; set; }

        /// <summary>
        /// A human-readable message providing more details about the error.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// The name of the parameter that caused the error, if applicable.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("param")]
        public string? Param { get; set; }

        /// <summary>
        /// The line number of the input file where the error occurred, if applicable.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("line")]
        public int? Line { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
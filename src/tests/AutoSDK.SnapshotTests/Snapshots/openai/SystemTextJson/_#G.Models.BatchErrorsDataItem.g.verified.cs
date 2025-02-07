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
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// A human-readable message providing more details about the error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// The name of the parameter that caused the error, if applicable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("param")]
        public string? Param { get; set; }

        /// <summary>
        /// The line number of the input file where the error occurred, if applicable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("line")]
        public int? Line { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchErrorsDataItem" /> class.
        /// </summary>
        /// <param name="code">
        /// An error code identifying the error type.
        /// </param>
        /// <param name="message">
        /// A human-readable message providing more details about the error.
        /// </param>
        /// <param name="param">
        /// The name of the parameter that caused the error, if applicable.
        /// </param>
        /// <param name="line">
        /// The line number of the input file where the error occurred, if applicable.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchErrorsDataItem(
            string? code,
            string? message,
            string? param,
            int? line)
        {
            this.Code = code;
            this.Message = message;
            this.Param = param;
            this.Line = line;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchErrorsDataItem" /> class.
        /// </summary>
        public BatchErrorsDataItem()
        {
        }
    }
}
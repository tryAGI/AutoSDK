//HintName: G.Models.ErrorInfoExperimentItemBulkWriteView.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ErrorInfoExperimentItemBulkWriteView
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exception_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExceptionType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traceback")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Traceback { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorInfoExperimentItemBulkWriteView" /> class.
        /// </summary>
        /// <param name="exceptionType"></param>
        /// <param name="traceback"></param>
        /// <param name="message"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ErrorInfoExperimentItemBulkWriteView(
            string exceptionType,
            string traceback,
            string? message)
        {
            this.ExceptionType = exceptionType ?? throw new global::System.ArgumentNullException(nameof(exceptionType));
            this.Message = message;
            this.Traceback = traceback ?? throw new global::System.ArgumentNullException(nameof(traceback));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorInfoExperimentItemBulkWriteView" /> class.
        /// </summary>
        public ErrorInfoExperimentItemBulkWriteView()
        {
        }
    }
}
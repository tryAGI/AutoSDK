//HintName: G.Models.PipelinesListPipelineSyncHistoryResponseRunError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PipelinesListPipelineSyncHistoryResponseRunError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ErrorType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ErrorMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinesListPipelineSyncHistoryResponseRunError" /> class.
        /// </summary>
        /// <param name="errorType"></param>
        /// <param name="errorMessage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PipelinesListPipelineSyncHistoryResponseRunError(
            string errorType,
            string errorMessage)
        {
            this.ErrorType = errorType ?? throw new global::System.ArgumentNullException(nameof(errorType));
            this.ErrorMessage = errorMessage ?? throw new global::System.ArgumentNullException(nameof(errorMessage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinesListPipelineSyncHistoryResponseRunError" /> class.
        /// </summary>
        public PipelinesListPipelineSyncHistoryResponseRunError()
        {
        }
    }
}
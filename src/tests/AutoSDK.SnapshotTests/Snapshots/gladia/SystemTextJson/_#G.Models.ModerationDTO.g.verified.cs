//HintName: G.Models.ModerationDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModerationDTO
    {
        /// <summary>
        /// The audio intelligence model succeeded to get a valid output
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        /// The audio intelligence model returned an empty value
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_empty")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsEmpty { get; set; }

        /// <summary>
        /// Time audio intelligence model took to complete the task
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exec_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ExecTime { get; set; }

        /// <summary>
        /// `null` if `success` is `true`. Contains the error details of the failed model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::G.AddonErrorDTO? Error { get; set; }

        /// <summary>
        /// If `moderation` has been enabled, moderated transcription
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        public string? Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationDTO" /> class.
        /// </summary>
        /// <param name="success">
        /// The audio intelligence model succeeded to get a valid output
        /// </param>
        /// <param name="isEmpty">
        /// The audio intelligence model returned an empty value
        /// </param>
        /// <param name="execTime">
        /// Time audio intelligence model took to complete the task
        /// </param>
        /// <param name="error">
        /// `null` if `success` is `true`. Contains the error details of the failed model
        /// </param>
        /// <param name="results">
        /// If `moderation` has been enabled, moderated transcription
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModerationDTO(
            bool success,
            bool isEmpty,
            double execTime,
            global::G.AddonErrorDTO? error,
            string? results)
        {
            this.Success = success;
            this.IsEmpty = isEmpty;
            this.ExecTime = execTime;
            this.Error = error;
            this.Results = results;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationDTO" /> class.
        /// </summary>
        public ModerationDTO()
        {
        }
    }
}
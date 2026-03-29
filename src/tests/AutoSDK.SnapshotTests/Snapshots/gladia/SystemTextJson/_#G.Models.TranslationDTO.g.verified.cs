//HintName: G.Models.TranslationDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranslationDTO
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
        /// List of translated transcriptions, one for each `target_languages`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.TranslationResultDTO> Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationDTO" /> class.
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
        /// <param name="results">
        /// List of translated transcriptions, one for each `target_languages`
        /// </param>
        /// <param name="error">
        /// `null` if `success` is `true`. Contains the error details of the failed model
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranslationDTO(
            bool success,
            bool isEmpty,
            double execTime,
            global::System.Collections.Generic.IList<global::G.TranslationResultDTO> results,
            global::G.AddonErrorDTO? error)
        {
            this.Success = success;
            this.IsEmpty = isEmpty;
            this.ExecTime = execTime;
            this.Error = error;
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationDTO" /> class.
        /// </summary>
        public TranslationDTO()
        {
        }
    }
}
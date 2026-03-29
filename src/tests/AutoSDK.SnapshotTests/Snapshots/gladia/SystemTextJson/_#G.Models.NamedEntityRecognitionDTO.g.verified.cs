//HintName: G.Models.NamedEntityRecognitionDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NamedEntityRecognitionDTO
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
        /// If `named_entity_recognition` has been enabled, the detected entities.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Entity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NamedEntityRecognitionDTO" /> class.
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
        /// <param name="entity">
        /// If `named_entity_recognition` has been enabled, the detected entities.
        /// </param>
        /// <param name="error">
        /// `null` if `success` is `true`. Contains the error details of the failed model
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NamedEntityRecognitionDTO(
            bool success,
            bool isEmpty,
            double execTime,
            string entity,
            global::G.AddonErrorDTO? error)
        {
            this.Success = success;
            this.IsEmpty = isEmpty;
            this.ExecTime = execTime;
            this.Error = error;
            this.Entity = entity ?? throw new global::System.ArgumentNullException(nameof(entity));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NamedEntityRecognitionDTO" /> class.
        /// </summary>
        public NamedEntityRecognitionDTO()
        {
        }
    }
}
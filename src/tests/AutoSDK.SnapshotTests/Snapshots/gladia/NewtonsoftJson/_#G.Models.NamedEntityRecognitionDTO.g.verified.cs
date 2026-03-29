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
        [global::Newtonsoft.Json.JsonProperty("success", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Success { get; set; } = default!;

        /// <summary>
        /// The audio intelligence model returned an empty value
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_empty", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsEmpty { get; set; } = default!;

        /// <summary>
        /// Time audio intelligence model took to complete the task
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exec_time", Required = global::Newtonsoft.Json.Required.Always)]
        public double ExecTime { get; set; } = default!;

        /// <summary>
        /// `null` if `success` is `true`. Contains the error details of the failed model
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public global::G.AddonErrorDTO? Error { get; set; }

        /// <summary>
        /// If `named_entity_recognition` has been enabled, the detected entities.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("entity", Required = global::Newtonsoft.Json.Required.Always)]
        public string Entity { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
//HintName: G.Models.FineTuningJobError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// For fine-tuning jobs that have `failed`, this will contain more information on the cause of the failure.
    /// </summary>
    public sealed partial class FineTuningJobError
    {
        /// <summary>
        /// A machine-readable error code.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code", Required = global::Newtonsoft.Json.Required.Always)]
        public string Code { get; set; } = default!;

        /// <summary>
        /// A human-readable error message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// The parameter that was invalid, usually `training_file` or `validation_file`. This field will be null if the failure was not parameter-specific.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("param", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Param { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
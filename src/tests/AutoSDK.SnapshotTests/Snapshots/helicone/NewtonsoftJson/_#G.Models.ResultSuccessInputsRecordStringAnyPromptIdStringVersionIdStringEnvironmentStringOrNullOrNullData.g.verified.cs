//HintName: G.Models.ResultSuccessInputsRecordStringAnyPromptIdStringVersionIdStringEnvironmentStringOrNullOrNullData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResultSuccessInputsRecordStringAnyPromptIdStringVersionIdStringEnvironmentStringOrNullOrNullData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("environment")]
        public string? Environment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string VersionId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string PromptId { get; set; } = default!;

        /// <summary>
        /// Construct a type with a set of properties K of type T
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RecordStringAny Inputs { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessInputsRecordStringAnyPromptIdStringVersionIdStringEnvironmentStringOrNullOrNullData" /> class.
        /// </summary>
        /// <param name="versionId"></param>
        /// <param name="promptId"></param>
        /// <param name="inputs">
        /// Construct a type with a set of properties K of type T
        /// </param>
        /// <param name="environment"></param>
        public ResultSuccessInputsRecordStringAnyPromptIdStringVersionIdStringEnvironmentStringOrNullOrNullData(
            string versionId,
            string promptId,
            global::G.RecordStringAny inputs,
            string? environment)
        {
            this.Environment = environment;
            this.VersionId = versionId ?? throw new global::System.ArgumentNullException(nameof(versionId));
            this.PromptId = promptId ?? throw new global::System.ArgumentNullException(nameof(promptId));
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessInputsRecordStringAnyPromptIdStringVersionIdStringEnvironmentStringOrNullOrNullData" /> class.
        /// </summary>
        public ResultSuccessInputsRecordStringAnyPromptIdStringVersionIdStringEnvironmentStringOrNullOrNullData()
        {
        }
    }
}
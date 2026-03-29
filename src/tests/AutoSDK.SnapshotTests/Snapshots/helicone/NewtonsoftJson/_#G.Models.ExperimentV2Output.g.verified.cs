//HintName: G.Models.ExperimentV2Output.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExperimentV2Output
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string RequestId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_original", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsOriginal { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_version_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string PromptVersionId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_record_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string InputRecordId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentV2Output" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestId"></param>
        /// <param name="isOriginal"></param>
        /// <param name="promptVersionId"></param>
        /// <param name="createdAt"></param>
        /// <param name="inputRecordId"></param>
        public ExperimentV2Output(
            string id,
            string requestId,
            bool isOriginal,
            string promptVersionId,
            string createdAt,
            string inputRecordId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.IsOriginal = isOriginal;
            this.PromptVersionId = promptVersionId ?? throw new global::System.ArgumentNullException(nameof(promptVersionId));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.InputRecordId = inputRecordId ?? throw new global::System.ArgumentNullException(nameof(inputRecordId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentV2Output" /> class.
        /// </summary>
        public ExperimentV2Output()
        {
        }
    }
}
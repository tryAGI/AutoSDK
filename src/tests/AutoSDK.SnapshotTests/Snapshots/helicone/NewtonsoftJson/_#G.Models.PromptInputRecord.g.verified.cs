//HintName: G.Models.PromptInputRecord.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptInputRecord
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Construct a type with a set of properties K of type T
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, string> Inputs { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_row_id")]
        public string? DatasetRowId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_request", Required = global::Newtonsoft.Json.Required.Always)]
        public string SourceRequest { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_version", Required = global::Newtonsoft.Json.Required.Always)]
        public string PromptVersion { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_body")]
        public string? ResponseBody { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_body")]
        public string? RequestBody { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auto_prompt_inputs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<object> AutoPromptInputs { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptInputRecord" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="inputs">
        /// Construct a type with a set of properties K of type T
        /// </param>
        /// <param name="sourceRequest"></param>
        /// <param name="promptVersion"></param>
        /// <param name="createdAt"></param>
        /// <param name="autoPromptInputs"></param>
        /// <param name="datasetRowId"></param>
        /// <param name="responseBody"></param>
        /// <param name="requestBody"></param>
        public PromptInputRecord(
            string id,
            global::System.Collections.Generic.Dictionary<string, string> inputs,
            string sourceRequest,
            string promptVersion,
            string createdAt,
            global::System.Collections.Generic.IList<object> autoPromptInputs,
            string? datasetRowId,
            string? responseBody,
            string? requestBody)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
            this.DatasetRowId = datasetRowId;
            this.SourceRequest = sourceRequest ?? throw new global::System.ArgumentNullException(nameof(sourceRequest));
            this.PromptVersion = promptVersion ?? throw new global::System.ArgumentNullException(nameof(promptVersion));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.ResponseBody = responseBody;
            this.RequestBody = requestBody;
            this.AutoPromptInputs = autoPromptInputs ?? throw new global::System.ArgumentNullException(nameof(autoPromptInputs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptInputRecord" /> class.
        /// </summary>
        public PromptInputRecord()
        {
        }
    }
}
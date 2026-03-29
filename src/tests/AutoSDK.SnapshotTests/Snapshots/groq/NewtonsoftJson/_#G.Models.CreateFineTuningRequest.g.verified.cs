//HintName: G.Models.CreateFineTuningRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateFineTuningRequest
    {
        /// <summary>
        /// BaseModel is the model that the fine tune was originally trained on.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("base_model")]
        public string? BaseModel { get; set; }

        /// <summary>
        /// InputFileID is the id of the file that was uploaded via the /files api.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_file_id")]
        public string? InputFileId { get; set; }

        /// <summary>
        /// Name is the given name to a fine tuned model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Type is the type of fine tuning format such as "lora".
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFineTuningRequest" /> class.
        /// </summary>
        /// <param name="baseModel">
        /// BaseModel is the model that the fine tune was originally trained on.
        /// </param>
        /// <param name="inputFileId">
        /// InputFileID is the id of the file that was uploaded via the /files api.
        /// </param>
        /// <param name="name">
        /// Name is the given name to a fine tuned model.
        /// </param>
        /// <param name="type">
        /// Type is the type of fine tuning format such as "lora".
        /// </param>
        public CreateFineTuningRequest(
            string? baseModel,
            string? inputFileId,
            string? name,
            string? type)
        {
            this.BaseModel = baseModel;
            this.InputFileId = inputFileId;
            this.Name = name;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFineTuningRequest" /> class.
        /// </summary>
        public CreateFineTuningRequest()
        {
        }
    }
}
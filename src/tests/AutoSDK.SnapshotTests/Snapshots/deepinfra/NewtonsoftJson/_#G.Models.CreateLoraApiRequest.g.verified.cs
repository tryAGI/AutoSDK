//HintName: G.Models.CreateLoraApiRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateLoraApiRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("base_model", Required = global::Newtonsoft.Json.Required.Always)]
        public string BaseModel { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lora_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string LoraName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SourceModel Source { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("private", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Private { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLoraApiRequest" /> class.
        /// </summary>
        /// <param name="baseModel"></param>
        /// <param name="loraName"></param>
        /// <param name="source"></param>
        /// <param name="private"></param>
        /// <param name="description"></param>
        public CreateLoraApiRequest(
            string baseModel,
            string loraName,
            global::G.SourceModel source,
            bool @private,
            string? description)
        {
            this.BaseModel = baseModel ?? throw new global::System.ArgumentNullException(nameof(baseModel));
            this.LoraName = loraName ?? throw new global::System.ArgumentNullException(nameof(loraName));
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.Private = @private;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLoraApiRequest" /> class.
        /// </summary>
        public CreateLoraApiRequest()
        {
        }
    }
}
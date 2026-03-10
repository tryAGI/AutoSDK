//HintName: G.Models.CompletionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CompletionResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("choices", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CompletionChoicesDataItem> Choices { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt")]
        public global::System.Collections.Generic.IList<global::G.PromptPartItem>? Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage")]
        public global::G.UsageData? Usage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created", Required = global::Newtonsoft.Json.Required.Always)]
        public int Created { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.CompletionResponseObject Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="choices"></param>
        /// <param name="prompt"></param>
        /// <param name="usage"></param>
        /// <param name="created"></param>
        /// <param name="model"></param>
        /// <param name="object"></param>
        public CompletionResponse(
            string id,
            global::System.Collections.Generic.IList<global::G.CompletionChoicesDataItem> choices,
            int created,
            string model,
            global::System.Collections.Generic.IList<global::G.PromptPartItem>? prompt,
            global::G.UsageData? usage,
            global::G.CompletionResponseObject @object)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Choices = choices ?? throw new global::System.ArgumentNullException(nameof(choices));
            this.Created = created;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Prompt = prompt;
            this.Usage = usage;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionResponse" /> class.
        /// </summary>
        public CompletionResponse()
        {
        }
    }
}
//HintName: G.Models.TunedModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A fine-tuned model created using ModelService.CreateTunedModel.
    /// </summary>
    public sealed partial class TunedModel
    {
        /// <summary>
        /// Tuned model as a source for training a new model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tunedModelSource")]
        public global::G.TunedModelSource? TunedModelSource { get; set; }

        /// <summary>
        /// Immutable. The name of the `Model` to tune. Example: `models/gemini-1.5-flash-001`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("baseModel")]
        public string? BaseModel { get; set; }

        /// <summary>
        /// Output only. The tuned model name. A unique name will be generated on create. Example: `tunedModels/az2mb0bpw6i` If display_name is set on create, the id portion of the name will be set by concatenating the words of the display_name with hyphens and adding a random portion for uniqueness. Example: * display_name = `Sentence Translator` * name = `tunedModels/sentence-translator-u3b7m`<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Optional. The name to display for this model in user interfaces. The display name must be up to 40 characters including spaces.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Optional. A short description of this model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Optional. Controls the randomness of the output. Values can range over `[0.0,1.0]`, inclusive. A value closer to `1.0` will produce responses that are more varied, while a value closer to `0.0` will typically result in less surprising responses from the model. This value specifies default to be the one used by the base model while creating the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public float? Temperature { get; set; }

        /// <summary>
        /// Optional. For Nucleus sampling. Nucleus sampling considers the smallest set of tokens whose probability sum is at least `top_p`. This value specifies default to be the one used by the base model while creating the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("topP")]
        public float? TopP { get; set; }

        /// <summary>
        /// Optional. For Top-k sampling. Top-k sampling considers the set of `top_k` most probable tokens. This value specifies default to be used by the backend while making the call to the model. This value specifies default to be the one used by the base model while creating the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("topK")]
        public int? TopK { get; set; }

        /// <summary>
        /// Output only. The state of the tuned model.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TunedModelStateJsonConverter))]
        public global::G.TunedModelState? State { get; set; }

        /// <summary>
        /// Output only. The timestamp when this model was created.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createTime")]
        public string? CreateTime { get; set; }

        /// <summary>
        /// Output only. The timestamp when this model was updated.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updateTime")]
        public string? UpdateTime { get; set; }

        /// <summary>
        /// Tuning tasks that create tuned models.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tuningTask")]
        public global::G.TuningTask? TuningTask { get; set; }

        /// <summary>
        /// Optional. List of project numbers that have read access to the tuned model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("readerProjectNumbers")]
        public global::System.Collections.Generic.IList<string>? ReaderProjectNumbers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TunedModel" /> class.
        /// </summary>
        /// <param name="tunedModelSource">
        /// Tuned model as a source for training a new model.
        /// </param>
        /// <param name="baseModel">
        /// Immutable. The name of the `Model` to tune. Example: `models/gemini-1.5-flash-001`
        /// </param>
        /// <param name="name">
        /// Output only. The tuned model name. A unique name will be generated on create. Example: `tunedModels/az2mb0bpw6i` If display_name is set on create, the id portion of the name will be set by concatenating the words of the display_name with hyphens and adding a random portion for uniqueness. Example: * display_name = `Sentence Translator` * name = `tunedModels/sentence-translator-u3b7m`<br/>
        /// Included only in responses
        /// </param>
        /// <param name="displayName">
        /// Optional. The name to display for this model in user interfaces. The display name must be up to 40 characters including spaces.
        /// </param>
        /// <param name="description">
        /// Optional. A short description of this model.
        /// </param>
        /// <param name="temperature">
        /// Optional. Controls the randomness of the output. Values can range over `[0.0,1.0]`, inclusive. A value closer to `1.0` will produce responses that are more varied, while a value closer to `0.0` will typically result in less surprising responses from the model. This value specifies default to be the one used by the base model while creating the model.
        /// </param>
        /// <param name="topP">
        /// Optional. For Nucleus sampling. Nucleus sampling considers the smallest set of tokens whose probability sum is at least `top_p`. This value specifies default to be the one used by the base model while creating the model.
        /// </param>
        /// <param name="topK">
        /// Optional. For Top-k sampling. Top-k sampling considers the set of `top_k` most probable tokens. This value specifies default to be used by the backend while making the call to the model. This value specifies default to be the one used by the base model while creating the model.
        /// </param>
        /// <param name="state">
        /// Output only. The state of the tuned model.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="createTime">
        /// Output only. The timestamp when this model was created.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="updateTime">
        /// Output only. The timestamp when this model was updated.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="tuningTask">
        /// Tuning tasks that create tuned models.
        /// </param>
        /// <param name="readerProjectNumbers">
        /// Optional. List of project numbers that have read access to the tuned model.
        /// </param>
        public TunedModel(
            global::G.TunedModelSource? tunedModelSource,
            string? baseModel,
            string? name,
            string? displayName,
            string? description,
            float? temperature,
            float? topP,
            int? topK,
            global::G.TunedModelState? state,
            string? createTime,
            string? updateTime,
            global::G.TuningTask? tuningTask,
            global::System.Collections.Generic.IList<string>? readerProjectNumbers)
        {
            this.TunedModelSource = tunedModelSource;
            this.BaseModel = baseModel;
            this.Name = name;
            this.DisplayName = displayName;
            this.Description = description;
            this.Temperature = temperature;
            this.TopP = topP;
            this.TopK = topK;
            this.State = state;
            this.CreateTime = createTime;
            this.UpdateTime = updateTime;
            this.TuningTask = tuningTask;
            this.ReaderProjectNumbers = readerProjectNumbers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TunedModel" /> class.
        /// </summary>
        public TunedModel()
        {
        }
    }
}
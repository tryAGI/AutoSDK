//HintName: G.Models.HuggingFaceInferenceAPIEmbedding.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HuggingFaceInferenceAPIEmbedding
    {
        /// <summary>
        /// Hugging Face model name. If None, the task will be used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_name")]
        public string? ModelName { get; set; }

        /// <summary>
        /// The batch size for embedding calls.<br/>
        /// Default Value: 10
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embed_batch_size")]
        public int? EmbedBatchSize { get; set; }

        /// <summary>
        /// The number of workers to use for async embedding calls.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_workers")]
        public int? NumWorkers { get; set; }

        /// <summary>
        /// Pooling strategy. If None, the model's default pooling is used.<br/>
        /// Default Value: cls
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pooling")]
        public global::G.Pooling? Pooling { get; set; }

        /// <summary>
        /// Instruction to prepend during query embedding.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("query_instruction")]
        public string? QueryInstruction { get; set; }

        /// <summary>
        /// Instruction to prepend during text embedding.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text_instruction")]
        public string? TextInstruction { get; set; }

        /// <summary>
        /// Hugging Face token. Will default to the locally saved token. Pass token=False if you don’t want to send your token to the server.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token")]
        public global::G.AnyOf<string, bool?, object>? Token { get; set; }

        /// <summary>
        /// The maximum number of seconds to wait for a response from the server. Loading a new model in Inference API can take up to several minutes. Defaults to None, meaning it will loop until the server is available.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeout")]
        public double? Timeout { get; set; }

        /// <summary>
        /// Additional headers to send to the server. By default only the authorization and user-agent headers are sent. Values in this dictionary will override the default values.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// Additional cookies to send to the server.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cookies")]
        public global::System.Collections.Generic.Dictionary<string, string>? Cookies { get; set; }

        /// <summary>
        /// Optional task to pick Hugging Face's recommended model, used when model_name is left as default of None.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("task")]
        public string? Task { get; set; }

        /// <summary>
        /// Default Value: HuggingFaceInferenceAPIEmbedding
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("class_name")]
        public string? ClassName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HuggingFaceInferenceAPIEmbedding" /> class.
        /// </summary>
        /// <param name="modelName">
        /// Hugging Face model name. If None, the task will be used.
        /// </param>
        /// <param name="embedBatchSize">
        /// The batch size for embedding calls.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="numWorkers">
        /// The number of workers to use for async embedding calls.
        /// </param>
        /// <param name="pooling">
        /// Pooling strategy. If None, the model's default pooling is used.<br/>
        /// Default Value: cls
        /// </param>
        /// <param name="queryInstruction">
        /// Instruction to prepend during query embedding.
        /// </param>
        /// <param name="textInstruction">
        /// Instruction to prepend during text embedding.
        /// </param>
        /// <param name="token">
        /// Hugging Face token. Will default to the locally saved token. Pass token=False if you don’t want to send your token to the server.
        /// </param>
        /// <param name="timeout">
        /// The maximum number of seconds to wait for a response from the server. Loading a new model in Inference API can take up to several minutes. Defaults to None, meaning it will loop until the server is available.
        /// </param>
        /// <param name="headers">
        /// Additional headers to send to the server. By default only the authorization and user-agent headers are sent. Values in this dictionary will override the default values.
        /// </param>
        /// <param name="cookies">
        /// Additional cookies to send to the server.
        /// </param>
        /// <param name="task">
        /// Optional task to pick Hugging Face's recommended model, used when model_name is left as default of None.
        /// </param>
        /// <param name="className">
        /// Default Value: HuggingFaceInferenceAPIEmbedding
        /// </param>
        public HuggingFaceInferenceAPIEmbedding(
            string? modelName,
            int? embedBatchSize,
            int? numWorkers,
            global::G.Pooling? pooling,
            string? queryInstruction,
            string? textInstruction,
            global::G.AnyOf<string, bool?, object>? token,
            double? timeout,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            global::System.Collections.Generic.Dictionary<string, string>? cookies,
            string? task,
            string? className)
        {
            this.ModelName = modelName;
            this.EmbedBatchSize = embedBatchSize;
            this.NumWorkers = numWorkers;
            this.Pooling = pooling;
            this.QueryInstruction = queryInstruction;
            this.TextInstruction = textInstruction;
            this.Token = token;
            this.Timeout = timeout;
            this.Headers = headers;
            this.Cookies = cookies;
            this.Task = task;
            this.ClassName = className;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HuggingFaceInferenceAPIEmbedding" /> class.
        /// </summary>
        public HuggingFaceInferenceAPIEmbedding()
        {
        }
    }
}
//HintName: G.Models.ModelInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelInfo
    {
        /// <summary>
        /// 携带上下文轮数
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("context_round")]
        public int? ContextRound { get; set; }

        /// <summary>
        /// 频率惩罚 没配置不返回
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("frequency_penalty")]
        public double? FrequencyPenalty { get; set; }

        /// <summary>
        /// 最大回复长度
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// 模型id
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_id")]
        public string? ModelId { get; set; }

        /// <summary>
        /// 模型名称
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_name")]
        public string? ModelName { get; set; }

        /// <summary>
        /// 存在惩罚 没配置不返回
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("presence_penalty")]
        public double? PresencePenalty { get; set; }

        /// <summary>
        /// 输出格式 text、markdown、json
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_format")]
        public string? ResponseFormat { get; set; }

        /// <summary>
        /// 生成随机性 没配置不返回
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// 生成时，采样候选集的大小 没配置不返回
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top_k")]
        public int? TopK { get; set; }

        /// <summary>
        /// top p 没配置不返回
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelInfo" /> class.
        /// </summary>
        /// <param name="contextRound">
        /// 携带上下文轮数
        /// </param>
        /// <param name="frequencyPenalty">
        /// 频率惩罚 没配置不返回
        /// </param>
        /// <param name="maxTokens">
        /// 最大回复长度
        /// </param>
        /// <param name="modelId">
        /// 模型id
        /// </param>
        /// <param name="modelName">
        /// 模型名称
        /// </param>
        /// <param name="presencePenalty">
        /// 存在惩罚 没配置不返回
        /// </param>
        /// <param name="responseFormat">
        /// 输出格式 text、markdown、json
        /// </param>
        /// <param name="temperature">
        /// 生成随机性 没配置不返回
        /// </param>
        /// <param name="topK">
        /// 生成时，采样候选集的大小 没配置不返回
        /// </param>
        /// <param name="topP">
        /// top p 没配置不返回
        /// </param>
        public ModelInfo(
            int? contextRound,
            double? frequencyPenalty,
            int? maxTokens,
            string? modelId,
            string? modelName,
            double? presencePenalty,
            string? responseFormat,
            double? temperature,
            int? topK,
            double? topP)
        {
            this.ContextRound = contextRound;
            this.FrequencyPenalty = frequencyPenalty;
            this.MaxTokens = maxTokens;
            this.ModelId = modelId;
            this.ModelName = modelName;
            this.PresencePenalty = presencePenalty;
            this.ResponseFormat = responseFormat;
            this.Temperature = temperature;
            this.TopK = topK;
            this.TopP = topP;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelInfo" /> class.
        /// </summary>
        public ModelInfo()
        {
        }
    }
}
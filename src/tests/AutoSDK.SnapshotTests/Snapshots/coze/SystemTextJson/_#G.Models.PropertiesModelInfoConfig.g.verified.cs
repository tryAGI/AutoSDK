//HintName: G.Models.PropertiesModelInfoConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PropertiesModelInfoConfig
    {
        /// <summary>
        /// 模型的API协议
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PropertiesModelInfoConfigApiModeJsonConverter))]
        public global::G.PropertiesModelInfoConfigApiMode? ApiMode { get; set; }

        /// <summary>
        /// 缓存配置
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PropertiesModelInfoConfigCacheTypeJsonConverter))]
        public global::G.PropertiesModelInfoConfigCacheType? CacheType { get; set; }

        /// <summary>
        /// 携带上下文轮数
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_round")]
        public int? ContextRound { get; set; }

        /// <summary>
        /// 频率惩罚
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frequency_penalty")]
        public double? FrequencyPenalty { get; set; }

        /// <summary>
        /// 最大回复长度
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// 模型id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelId { get; set; }

        /// <summary>
        /// 模型个性化配置参数
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::System.Collections.Generic.Dictionary<string, string>? Parameters { get; set; }

        /// <summary>
        /// 存在惩罚
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presence_penalty")]
        public double? PresencePenalty { get; set; }

        /// <summary>
        /// 输出格式 text、markdown、json
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        public string? ResponseFormat { get; set; }

        /// <summary>
        /// sp拼接防泄露指令
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sp_anti_leak")]
        public bool? SpAntiLeak { get; set; }

        /// <summary>
        /// sp拼接当前时间
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sp_current_time")]
        public bool? SpCurrentTime { get; set; }

        /// <summary>
        /// 生成随机性
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// 生成时，采样候选集的大小
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_k")]
        public int? TopK { get; set; }

        /// <summary>
        /// top p
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesModelInfoConfig" /> class.
        /// </summary>
        /// <param name="modelId">
        /// 模型id
        /// </param>
        /// <param name="apiMode">
        /// 模型的API协议
        /// </param>
        /// <param name="cacheType">
        /// 缓存配置
        /// </param>
        /// <param name="contextRound">
        /// 携带上下文轮数
        /// </param>
        /// <param name="frequencyPenalty">
        /// 频率惩罚
        /// </param>
        /// <param name="maxTokens">
        /// 最大回复长度
        /// </param>
        /// <param name="parameters">
        /// 模型个性化配置参数
        /// </param>
        /// <param name="presencePenalty">
        /// 存在惩罚
        /// </param>
        /// <param name="responseFormat">
        /// 输出格式 text、markdown、json
        /// </param>
        /// <param name="spAntiLeak">
        /// sp拼接防泄露指令
        /// </param>
        /// <param name="spCurrentTime">
        /// sp拼接当前时间
        /// </param>
        /// <param name="temperature">
        /// 生成随机性
        /// </param>
        /// <param name="topK">
        /// 生成时，采样候选集的大小
        /// </param>
        /// <param name="topP">
        /// top p
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PropertiesModelInfoConfig(
            string modelId,
            global::G.PropertiesModelInfoConfigApiMode? apiMode,
            global::G.PropertiesModelInfoConfigCacheType? cacheType,
            int? contextRound,
            double? frequencyPenalty,
            int? maxTokens,
            global::System.Collections.Generic.Dictionary<string, string>? parameters,
            double? presencePenalty,
            string? responseFormat,
            bool? spAntiLeak,
            bool? spCurrentTime,
            double? temperature,
            int? topK,
            double? topP)
        {
            this.ApiMode = apiMode;
            this.CacheType = cacheType;
            this.ContextRound = contextRound;
            this.FrequencyPenalty = frequencyPenalty;
            this.MaxTokens = maxTokens;
            this.ModelId = modelId ?? throw new global::System.ArgumentNullException(nameof(modelId));
            this.Parameters = parameters;
            this.PresencePenalty = presencePenalty;
            this.ResponseFormat = responseFormat;
            this.SpAntiLeak = spAntiLeak;
            this.SpCurrentTime = spCurrentTime;
            this.Temperature = temperature;
            this.TopK = topK;
            this.TopP = topP;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesModelInfoConfig" /> class.
        /// </summary>
        public PropertiesModelInfoConfig()
        {
        }
    }
}
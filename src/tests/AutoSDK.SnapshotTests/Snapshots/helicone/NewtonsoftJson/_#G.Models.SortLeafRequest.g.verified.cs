//HintName: G.Models.SortLeafRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SortLeafRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("random")]
        public bool? Random { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::G.SortDirection? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cache_created_at")]
        public global::G.SortDirection? CacheCreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("latency")]
        public global::G.SortDirection? Latency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_active")]
        public global::G.SortDirection? LastActive { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_tokens")]
        public global::G.SortDirection? TotalTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completion_tokens")]
        public global::G.SortDirection? CompletionTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_tokens")]
        public global::G.SortDirection? PromptTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id")]
        public global::G.SortDirection? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body_model")]
        public global::G.SortDirection? BodyModel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_cached")]
        public global::G.SortDirection? IsCached { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_prompt")]
        public global::G.SortDirection? RequestPrompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_text")]
        public global::G.SortDirection? ResponseText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("properties")]
        public global::System.Collections.Generic.Dictionary<string, global::G.SortDirection>? Properties { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("values")]
        public global::System.Collections.Generic.Dictionary<string, global::G.SortDirection>? Values { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cost")]
        public global::G.SortDirection? Cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("time_to_first_token")]
        public global::G.SortDirection? TimeToFirstToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SortLeafRequest" /> class.
        /// </summary>
        /// <param name="random"></param>
        /// <param name="createdAt"></param>
        /// <param name="cacheCreatedAt"></param>
        /// <param name="latency"></param>
        /// <param name="lastActive"></param>
        /// <param name="totalTokens"></param>
        /// <param name="completionTokens"></param>
        /// <param name="promptTokens"></param>
        /// <param name="userId"></param>
        /// <param name="bodyModel"></param>
        /// <param name="isCached"></param>
        /// <param name="requestPrompt"></param>
        /// <param name="responseText"></param>
        /// <param name="properties"></param>
        /// <param name="values"></param>
        /// <param name="cost"></param>
        /// <param name="timeToFirstToken"></param>
        public SortLeafRequest(
            bool? random,
            global::G.SortDirection? createdAt,
            global::G.SortDirection? cacheCreatedAt,
            global::G.SortDirection? latency,
            global::G.SortDirection? lastActive,
            global::G.SortDirection? totalTokens,
            global::G.SortDirection? completionTokens,
            global::G.SortDirection? promptTokens,
            global::G.SortDirection? userId,
            global::G.SortDirection? bodyModel,
            global::G.SortDirection? isCached,
            global::G.SortDirection? requestPrompt,
            global::G.SortDirection? responseText,
            global::System.Collections.Generic.Dictionary<string, global::G.SortDirection>? properties,
            global::System.Collections.Generic.Dictionary<string, global::G.SortDirection>? values,
            global::G.SortDirection? cost,
            global::G.SortDirection? timeToFirstToken)
        {
            this.Random = random;
            this.CreatedAt = createdAt;
            this.CacheCreatedAt = cacheCreatedAt;
            this.Latency = latency;
            this.LastActive = lastActive;
            this.TotalTokens = totalTokens;
            this.CompletionTokens = completionTokens;
            this.PromptTokens = promptTokens;
            this.UserId = userId;
            this.BodyModel = bodyModel;
            this.IsCached = isCached;
            this.RequestPrompt = requestPrompt;
            this.ResponseText = responseText;
            this.Properties = properties;
            this.Values = values;
            this.Cost = cost;
            this.TimeToFirstToken = timeToFirstToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SortLeafRequest" /> class.
        /// </summary>
        public SortLeafRequest()
        {
        }
    }
}
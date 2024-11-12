//HintName: G.Models.FinetuneEvent2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FinetuneEvent2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hash")]
        public string? Hash { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("level")]
        public global::G.FinetuneEventLevels? Level { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.FinetuneEventObject2? Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("param_count")]
        public int? ParamCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token_count")]
        public int? TokenCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.FinetuneEventType2? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("wandb_url")]
        public string? WandbUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FinetuneEvent2" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="hash"></param>
        /// <param name="level"></param>
        /// <param name="message"></param>
        /// <param name="object"></param>
        /// <param name="paramCount"></param>
        /// <param name="tokenCount"></param>
        /// <param name="type"></param>
        /// <param name="wandbUrl"></param>
        public FinetuneEvent2(
            string? createdAt,
            string? hash,
            global::G.FinetuneEventLevels? level,
            string? message,
            global::G.FinetuneEventObject2? @object,
            int? paramCount,
            int? tokenCount,
            global::G.FinetuneEventType2? type,
            string? wandbUrl)
        {
            this.CreatedAt = createdAt;
            this.Hash = hash;
            this.Level = level;
            this.Message = message;
            this.Object = @object;
            this.ParamCount = paramCount;
            this.TokenCount = tokenCount;
            this.Type = type;
            this.WandbUrl = wandbUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FinetuneEvent2" /> class.
        /// </summary>
        public FinetuneEvent2()
        {
        }
    }
}
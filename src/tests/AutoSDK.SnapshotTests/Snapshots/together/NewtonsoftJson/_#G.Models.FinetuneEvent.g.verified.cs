//HintName: G.Models.FinetuneEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FinetuneEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.FinetuneEventObject? Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public string? CreatedAt { get; set; }

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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.FinetuneEventType? Type { get; set; }

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
        [global::Newtonsoft.Json.JsonProperty("wandb_url")]
        public string? WandbUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hash")]
        public string? Hash { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FinetuneEvent" /> class.
        /// </summary>
        /// <param name="object"></param>
        /// <param name="createdAt"></param>
        /// <param name="level"></param>
        /// <param name="message"></param>
        /// <param name="type"></param>
        /// <param name="paramCount"></param>
        /// <param name="tokenCount"></param>
        /// <param name="wandbUrl"></param>
        /// <param name="hash"></param>
        public FinetuneEvent(
            global::G.FinetuneEventObject? @object,
            string? createdAt,
            global::G.FinetuneEventLevels? level,
            string? message,
            global::G.FinetuneEventType? type,
            int? paramCount,
            int? tokenCount,
            string? wandbUrl,
            string? hash)
        {
            this.Object = @object;
            this.CreatedAt = createdAt;
            this.Level = level;
            this.Message = message;
            this.Type = type;
            this.ParamCount = paramCount;
            this.TokenCount = tokenCount;
            this.WandbUrl = wandbUrl;
            this.Hash = hash;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FinetuneEvent" /> class.
        /// </summary>
        public FinetuneEvent()
        {
        }
    }
}
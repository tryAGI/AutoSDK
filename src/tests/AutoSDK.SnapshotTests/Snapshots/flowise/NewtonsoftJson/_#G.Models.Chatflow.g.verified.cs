//HintName: G.Models.Chatflow.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Chatflow
    {
        /// <summary>
        /// Example: d290f1ee-6c54-4b01-90e6-d701748f0851
        /// </summary>
        /// <example>d290f1ee-6c54-4b01-90e6-d701748f0851</example>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Example: MyChatFlow
        /// </summary>
        /// <example>MyChatFlow</example>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Example: {}
        /// </summary>
        /// <example>{}</example>
        [global::Newtonsoft.Json.JsonProperty("flowData")]
        public string? FlowData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deployed")]
        public bool? Deployed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("isPublic")]
        public bool? IsPublic { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("apikeyid")]
        public string? Apikeyid { get; set; }

        /// <summary>
        /// Example: {}
        /// </summary>
        /// <example>{}</example>
        [global::Newtonsoft.Json.JsonProperty("chatbotConfig")]
        public string? ChatbotConfig { get; set; }

        /// <summary>
        /// Example: {}
        /// </summary>
        /// <example>{}</example>
        [global::Newtonsoft.Json.JsonProperty("apiConfig")]
        public string? ApiConfig { get; set; }

        /// <summary>
        /// Example: {}
        /// </summary>
        /// <example>{}</example>
        [global::Newtonsoft.Json.JsonProperty("analytic")]
        public string? Analytic { get; set; }

        /// <summary>
        /// Example: {}
        /// </summary>
        /// <example>{}</example>
        [global::Newtonsoft.Json.JsonProperty("speechToText")]
        public string? SpeechToText { get; set; }

        /// <summary>
        /// Example: category1;category2
        /// </summary>
        /// <example>category1;category2</example>
        [global::Newtonsoft.Json.JsonProperty("category")]
        public string? Category { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ChatflowTypeJsonConverter))]
        public global::G.ChatflowType? Type { get; set; }

        /// <summary>
        /// Example: 2024-08-24T14:15:22Z
        /// </summary>
        /// <example>2024-08-24T14:15:22Z</example>
        [global::Newtonsoft.Json.JsonProperty("createdDate")]
        public global::System.DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Example: 2024-08-24T14:15:22Z
        /// </summary>
        /// <example>2024-08-24T14:15:22Z</example>
        [global::Newtonsoft.Json.JsonProperty("updatedDate")]
        public global::System.DateTime? UpdatedDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Chatflow" /> class.
        /// </summary>
        /// <param name="id">
        /// Example: d290f1ee-6c54-4b01-90e6-d701748f0851
        /// </param>
        /// <param name="name">
        /// Example: MyChatFlow
        /// </param>
        /// <param name="flowData">
        /// Example: {}
        /// </param>
        /// <param name="deployed"></param>
        /// <param name="isPublic"></param>
        /// <param name="apikeyid"></param>
        /// <param name="chatbotConfig">
        /// Example: {}
        /// </param>
        /// <param name="apiConfig">
        /// Example: {}
        /// </param>
        /// <param name="analytic">
        /// Example: {}
        /// </param>
        /// <param name="speechToText">
        /// Example: {}
        /// </param>
        /// <param name="category">
        /// Example: category1;category2
        /// </param>
        /// <param name="type"></param>
        /// <param name="createdDate">
        /// Example: 2024-08-24T14:15:22Z
        /// </param>
        /// <param name="updatedDate">
        /// Example: 2024-08-24T14:15:22Z
        /// </param>
        public Chatflow(
            string? id,
            string? name,
            string? flowData,
            bool? deployed,
            bool? isPublic,
            string? apikeyid,
            string? chatbotConfig,
            string? apiConfig,
            string? analytic,
            string? speechToText,
            string? category,
            global::G.ChatflowType? type,
            global::System.DateTime? createdDate,
            global::System.DateTime? updatedDate)
        {
            this.Id = id;
            this.Name = name;
            this.FlowData = flowData;
            this.Deployed = deployed;
            this.IsPublic = isPublic;
            this.Apikeyid = apikeyid;
            this.ChatbotConfig = chatbotConfig;
            this.ApiConfig = apiConfig;
            this.Analytic = analytic;
            this.SpeechToText = speechToText;
            this.Category = category;
            this.Type = type;
            this.CreatedDate = createdDate;
            this.UpdatedDate = updatedDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Chatflow" /> class.
        /// </summary>
        public Chatflow()
        {
        }
    }
}
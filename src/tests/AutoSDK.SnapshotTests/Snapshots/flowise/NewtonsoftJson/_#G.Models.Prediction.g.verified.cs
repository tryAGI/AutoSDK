//HintName: G.Models.Prediction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Prediction
    {
        /// <summary>
        /// The question/message to send to the flow<br/>
        /// Example: What is artificial intelligence?
        /// </summary>
        /// <example>What is artificial intelligence?</example>
        [global::Newtonsoft.Json.JsonProperty("question")]
        public string? Question { get; set; }

        /// <summary>
        /// The form object to send to the flow (alternative to question for Agentflow V2)<br/>
        /// Example: {"title":"Example","count":1}
        /// </summary>
        /// <example>{"title":"Example","count":1}</example>
        [global::Newtonsoft.Json.JsonProperty("form")]
        public object? Form { get; set; }

        /// <summary>
        /// Enable streaming responses for real-time output<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::Newtonsoft.Json.JsonProperty("streaming")]
        public bool? Streaming { get; set; }

        /// <summary>
        /// Override flow configuration and pass variables at runtime<br/>
        /// Example: {"sessionId":"user-session-123","temperature":0.7,"maxTokens":500,"vars":{"user_name":"Alice"}}
        /// </summary>
        /// <example>{"sessionId":"user-session-123","temperature":0.7,"maxTokens":500,"vars":{"user_name":"Alice"}}</example>
        [global::Newtonsoft.Json.JsonProperty("overrideConfig")]
        public object? OverrideConfig { get; set; }

        /// <summary>
        /// Previous conversation messages for context<br/>
        /// Example: [{"role":"apiMessage","content":"Hello! I\u0027m an AI assistant. How can I help you today?"}, {"role":"userMessage","content":"Hi, my name is Sarah and I\u0027m learning about AI"}]
        /// </summary>
        /// <example>[{"role":"apiMessage","content":"Hello! I\u0027m an AI assistant. How can I help you today?"}, {"role":"userMessage","content":"Hi, my name is Sarah and I\u0027m learning about AI"}]</example>
        [global::Newtonsoft.Json.JsonProperty("history")]
        public global::System.Collections.Generic.IList<global::G.PredictionHistoryItem>? History { get; set; }

        /// <summary>
        /// Files to upload (images, audio, documents, etc.)<br/>
        /// Example: [{"type":"file","name":"example.png","data":"data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAABjElEQVRIS\u002B2Vv0oDQRDG","mime":"image/png"}]
        /// </summary>
        /// <example>[{"type":"file","name":"example.png","data":"data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAABjElEQVRIS\u002B2Vv0oDQRDG","mime":"image/png"}]</example>
        [global::Newtonsoft.Json.JsonProperty("uploads")]
        public global::System.Collections.Generic.IList<global::G.PredictionUpload>? Uploads { get; set; }

        /// <summary>
        /// Return human feedback and resume execution from a stopped checkpoint<br/>
        /// Example: {"type":"reject","feedback":"Include more emoji"}
        /// </summary>
        /// <example>{"type":"reject","feedback":"Include more emoji"}</example>
        [global::Newtonsoft.Json.JsonProperty("humanInput")]
        public global::G.PredictionHumanInput? HumanInput { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Prediction" /> class.
        /// </summary>
        /// <param name="question">
        /// The question/message to send to the flow<br/>
        /// Example: What is artificial intelligence?
        /// </param>
        /// <param name="form">
        /// The form object to send to the flow (alternative to question for Agentflow V2)<br/>
        /// Example: {"title":"Example","count":1}
        /// </param>
        /// <param name="streaming">
        /// Enable streaming responses for real-time output<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
        /// <param name="overrideConfig">
        /// Override flow configuration and pass variables at runtime<br/>
        /// Example: {"sessionId":"user-session-123","temperature":0.7,"maxTokens":500,"vars":{"user_name":"Alice"}}
        /// </param>
        /// <param name="history">
        /// Previous conversation messages for context<br/>
        /// Example: [{"role":"apiMessage","content":"Hello! I\u0027m an AI assistant. How can I help you today?"}, {"role":"userMessage","content":"Hi, my name is Sarah and I\u0027m learning about AI"}]
        /// </param>
        /// <param name="uploads">
        /// Files to upload (images, audio, documents, etc.)<br/>
        /// Example: [{"type":"file","name":"example.png","data":"data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAABjElEQVRIS\u002B2Vv0oDQRDG","mime":"image/png"}]
        /// </param>
        /// <param name="humanInput">
        /// Return human feedback and resume execution from a stopped checkpoint<br/>
        /// Example: {"type":"reject","feedback":"Include more emoji"}
        /// </param>
        public Prediction(
            string? question,
            object? form,
            bool? streaming,
            object? overrideConfig,
            global::System.Collections.Generic.IList<global::G.PredictionHistoryItem>? history,
            global::System.Collections.Generic.IList<global::G.PredictionUpload>? uploads,
            global::G.PredictionHumanInput? humanInput)
        {
            this.Question = question;
            this.Form = form;
            this.Streaming = streaming;
            this.OverrideConfig = overrideConfig;
            this.History = history;
            this.Uploads = uploads;
            this.HumanInput = humanInput;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Prediction" /> class.
        /// </summary>
        public Prediction()
        {
        }
    }
}
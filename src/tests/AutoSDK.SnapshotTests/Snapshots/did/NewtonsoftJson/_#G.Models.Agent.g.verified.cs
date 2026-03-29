//HintName: G.Models.Agent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Agent
    {
        /// <summary>
        /// Id of agent
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Description of the agent
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("preview_description")]
        public string? PreviewDescription { get; set; }

        /// <summary>
        /// Presenter who will show in the chat with the user<br/>
        /// Types of presenters below, you could choose 1 option
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("presenter")]
        public global::G.AnyOf<global::G.AgentPresenterPhotoAvatar2, global::G.AgentPresenterVideoAvatar2, global::G.AgentPresenterExpressiveAvatar2>? Presenter { get; set; }

        /// <summary>
        /// Configuration for the Large Language Model used by the Agent to generate responses.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("llm")]
        public global::G.AnyOf<global::G.AgentLlmOpenAI, global::G.AgentLlmVariant2, global::G.AgentLlmVariant3, global::G.AgentLlmDId, global::G.AgentLlmGoogle>? Llm { get; set; }

        /// <summary>
        /// The provider of the agent
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        public global::G.AgentProvider? Provider { get; set; }

        /// <summary>
        /// Knowledge documents base where the agent will look for answers
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("knowledge")]
        public global::G.AgentKnowledge? Knowledge { get; set; }

        /// <summary>
        /// List of messages to be showen as chat starter questions for the user to ask
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("starter_message")]
        public global::System.Collections.Generic.IList<string>? StarterMessage { get; set; }

        /// <summary>
        /// Greeting messages for the agent<br/>
        /// One greeting is randomly displayed at the start of the chat
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("greetings")]
        public global::System.Collections.Generic.IList<string>? Greetings { get; set; }

        /// <summary>
        /// Error object in case of errors
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public global::G.AgentError? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_data")]
        public string? UserData { get; set; }

        /// <summary>
        /// Wether to embed the agent<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embed")]
        public bool? Embed { get; set; }

        /// <summary>
        /// Trigger configurations for this agent
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("triggers")]
        public global::G.AgentTriggers? Triggers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Agent" /> class.
        /// </summary>
        /// <param name="id">
        /// Id of agent
        /// </param>
        /// <param name="previewDescription">
        /// Description of the agent
        /// </param>
        /// <param name="presenter">
        /// Presenter who will show in the chat with the user<br/>
        /// Types of presenters below, you could choose 1 option
        /// </param>
        /// <param name="llm">
        /// Configuration for the Large Language Model used by the Agent to generate responses.
        /// </param>
        /// <param name="provider">
        /// The provider of the agent
        /// </param>
        /// <param name="knowledge">
        /// Knowledge documents base where the agent will look for answers
        /// </param>
        /// <param name="starterMessage">
        /// List of messages to be showen as chat starter questions for the user to ask
        /// </param>
        /// <param name="greetings">
        /// Greeting messages for the agent<br/>
        /// One greeting is randomly displayed at the start of the chat
        /// </param>
        /// <param name="error">
        /// Error object in case of errors
        /// </param>
        /// <param name="userData"></param>
        /// <param name="embed">
        /// Wether to embed the agent<br/>
        /// Default Value: false
        /// </param>
        /// <param name="triggers">
        /// Trigger configurations for this agent
        /// </param>
        public Agent(
            string id,
            string? previewDescription,
            global::G.AnyOf<global::G.AgentPresenterPhotoAvatar2, global::G.AgentPresenterVideoAvatar2, global::G.AgentPresenterExpressiveAvatar2>? presenter,
            global::G.AnyOf<global::G.AgentLlmOpenAI, global::G.AgentLlmVariant2, global::G.AgentLlmVariant3, global::G.AgentLlmDId, global::G.AgentLlmGoogle>? llm,
            global::G.AgentProvider? provider,
            global::G.AgentKnowledge? knowledge,
            global::System.Collections.Generic.IList<string>? starterMessage,
            global::System.Collections.Generic.IList<string>? greetings,
            global::G.AgentError? error,
            string? userData,
            bool? embed,
            global::G.AgentTriggers? triggers)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.PreviewDescription = previewDescription;
            this.Presenter = presenter;
            this.Llm = llm;
            this.Provider = provider;
            this.Knowledge = knowledge;
            this.StarterMessage = starterMessage;
            this.Greetings = greetings;
            this.Error = error;
            this.UserData = userData;
            this.Embed = embed;
            this.Triggers = triggers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Agent" /> class.
        /// </summary>
        public Agent()
        {
        }
    }
}
//HintName: G.Models.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssets.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// From T, pick a set of properties whose keys are in the union K
    /// </summary>
    public sealed partial class PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssets
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
        public global::G.AnyOf<global::G.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatar, global::G.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatar, global::G.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatar>? Presenter { get; set; }

        /// <summary>
        /// Configuration for the Large Language Model used by the Agent to generate responses.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("llm")]
        public global::G.AnyOf<global::G.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAI, global::G.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant2, global::G.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant3, global::G.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmDId, global::G.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmGoogle>? Llm { get; set; }

        /// <summary>
        /// The provider of the agent
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        public global::G.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsProvider? Provider { get; set; }

        /// <summary>
        /// Knowledge documents base where the agent will look for answers
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("knowledge")]
        public global::G.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsKnowledge? Knowledge { get; set; }

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
        public global::G.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsError? Error { get; set; }

        /// <summary>
        /// Trigger configurations for this agent
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("triggers")]
        public global::G.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsTriggers? Triggers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssets" /> class.
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
        /// <param name="triggers">
        /// Trigger configurations for this agent
        /// </param>
        public PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssets(
            string id,
            string? previewDescription,
            global::G.AnyOf<global::G.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterPhotoAvatar, global::G.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterVideoAvatar, global::G.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsPresenterExpressiveAvatar>? presenter,
            global::G.AnyOf<global::G.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmOpenAI, global::G.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant2, global::G.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant3, global::G.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmDId, global::G.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmGoogle>? llm,
            global::G.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsProvider? provider,
            global::G.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsKnowledge? knowledge,
            global::System.Collections.Generic.IList<string>? starterMessage,
            global::System.Collections.Generic.IList<string>? greetings,
            global::G.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsError? error,
            global::G.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsTriggers? triggers)
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
            this.Triggers = triggers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssets" /> class.
        /// </summary>
        public PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssets()
        {
        }
    }
}
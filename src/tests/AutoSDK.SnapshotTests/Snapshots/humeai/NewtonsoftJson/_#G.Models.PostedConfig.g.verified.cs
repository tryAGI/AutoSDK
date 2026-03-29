//HintName: G.Models.PostedConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostedConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version_description")]
        public string? VersionDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("evi_version")]
        public string? EviVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt")]
        public global::G.PostedConfigPromptSpec? Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice")]
        public global::G.PostedUtteranceVoice? Voice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language_model")]
        public global::G.PostedLanguageModel? LanguageModel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ellm_model")]
        public global::G.PostedEllmModel? EllmModel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tools")]
        public global::System.Collections.Generic.IList<global::G.PostedUserDefinedToolSpec>? Tools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("builtin_tools")]
        public global::System.Collections.Generic.IList<global::G.PostedBuiltinTool>? BuiltinTools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_messages")]
        public global::G.PostedEventMessageSpecs? EventMessages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeouts")]
        public global::G.PostedTimeoutSpecs? Timeouts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostedConfig" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="versionDescription"></param>
        /// <param name="eviVersion"></param>
        /// <param name="prompt"></param>
        /// <param name="voice"></param>
        /// <param name="languageModel"></param>
        /// <param name="ellmModel"></param>
        /// <param name="tools"></param>
        /// <param name="builtinTools"></param>
        /// <param name="eventMessages"></param>
        /// <param name="timeouts"></param>
        public PostedConfig(
            string name,
            string? versionDescription,
            string? eviVersion,
            global::G.PostedConfigPromptSpec? prompt,
            global::G.PostedUtteranceVoice? voice,
            global::G.PostedLanguageModel? languageModel,
            global::G.PostedEllmModel? ellmModel,
            global::System.Collections.Generic.IList<global::G.PostedUserDefinedToolSpec>? tools,
            global::System.Collections.Generic.IList<global::G.PostedBuiltinTool>? builtinTools,
            global::G.PostedEventMessageSpecs? eventMessages,
            global::G.PostedTimeoutSpecs? timeouts)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.VersionDescription = versionDescription;
            this.EviVersion = eviVersion;
            this.Prompt = prompt;
            this.Voice = voice;
            this.LanguageModel = languageModel;
            this.EllmModel = ellmModel;
            this.Tools = tools;
            this.BuiltinTools = builtinTools;
            this.EventMessages = eventMessages;
            this.Timeouts = timeouts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostedConfig" /> class.
        /// </summary>
        public PostedConfig()
        {
        }
    }
}
//HintName: G.Models.ReturnConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReturnConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version")]
        public int? Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version_type")]
        public string? VersionType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version_description")]
        public string? VersionDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_on")]
        public long? CreatedOn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modified_on")]
        public long? ModifiedOn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("evi_version")]
        public string? EviVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt")]
        public global::G.ReturnConfigPromptSpec? Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice")]
        public global::G.ReturnVoice? Voice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language_model")]
        public global::G.ReturnLanguageModel? LanguageModel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ellm_model")]
        public global::G.ReturnEllmModel? EllmModel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tools")]
        public global::System.Collections.Generic.IList<global::G.ReturnToolItem>? Tools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("builtin_tools")]
        public global::System.Collections.Generic.IList<global::G.ReturnBuiltinTool>? BuiltinTools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_messages")]
        public global::G.ReturnEventMessageSpecs? EventMessages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeouts")]
        public global::G.ReturnTimeoutSpecs? Timeouts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnConfig" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="version"></param>
        /// <param name="versionType"></param>
        /// <param name="versionDescription"></param>
        /// <param name="name"></param>
        /// <param name="createdOn"></param>
        /// <param name="modifiedOn"></param>
        /// <param name="eviVersion"></param>
        /// <param name="prompt"></param>
        /// <param name="voice"></param>
        /// <param name="languageModel"></param>
        /// <param name="ellmModel"></param>
        /// <param name="tools"></param>
        /// <param name="builtinTools"></param>
        /// <param name="eventMessages"></param>
        /// <param name="timeouts"></param>
        public ReturnConfig(
            string? id,
            int? version,
            string? versionType,
            string? versionDescription,
            string? name,
            long? createdOn,
            long? modifiedOn,
            string? eviVersion,
            global::G.ReturnConfigPromptSpec? prompt,
            global::G.ReturnVoice? voice,
            global::G.ReturnLanguageModel? languageModel,
            global::G.ReturnEllmModel? ellmModel,
            global::System.Collections.Generic.IList<global::G.ReturnToolItem>? tools,
            global::System.Collections.Generic.IList<global::G.ReturnBuiltinTool>? builtinTools,
            global::G.ReturnEventMessageSpecs? eventMessages,
            global::G.ReturnTimeoutSpecs? timeouts)
        {
            this.Id = id;
            this.Version = version;
            this.VersionType = versionType;
            this.VersionDescription = versionDescription;
            this.Name = name;
            this.CreatedOn = createdOn;
            this.ModifiedOn = modifiedOn;
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
        /// Initializes a new instance of the <see cref="ReturnConfig" /> class.
        /// </summary>
        public ReturnConfig()
        {
        }
    }
}
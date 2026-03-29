//HintName: G.Models.BotConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BotConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("character_name")]
        public string? CharacterName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("propmt")]
        public string? Propmt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BotConfig" /> class.
        /// </summary>
        /// <param name="characterName"></param>
        /// <param name="propmt"></param>
        public BotConfig(
            string? characterName,
            string? propmt)
        {
            this.CharacterName = characterName;
            this.Propmt = propmt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BotConfig" /> class.
        /// </summary>
        public BotConfig()
        {
        }
    }
}
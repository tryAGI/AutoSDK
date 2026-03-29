//HintName: G.Models.PostedUtteranceVoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostedUtteranceVoice
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        public global::G.PostedUtteranceVoiceProvider? Provider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostedUtteranceVoice" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="provider"></param>
        public PostedUtteranceVoice(
            string? id,
            string? name,
            global::G.PostedUtteranceVoiceProvider? provider)
        {
            this.Id = id;
            this.Name = name;
            this.Provider = provider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostedUtteranceVoice" /> class.
        /// </summary>
        public PostedUtteranceVoice()
        {
        }
    }
}
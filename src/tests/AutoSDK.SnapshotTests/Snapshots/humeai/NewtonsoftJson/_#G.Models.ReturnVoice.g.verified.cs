//HintName: G.Models.ReturnVoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReturnVoice
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
        public global::G.ReturnVoiceProvider? Provider { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnVoice" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="provider"></param>
        /// <param name="createdOn"></param>
        /// <param name="modifiedOn"></param>
        public ReturnVoice(
            string? id,
            string? name,
            global::G.ReturnVoiceProvider? provider,
            long? createdOn,
            long? modifiedOn)
        {
            this.Id = id;
            this.Name = name;
            this.Provider = provider;
            this.CreatedOn = createdOn;
            this.ModifiedOn = modifiedOn;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnVoice" /> class.
        /// </summary>
        public ReturnVoice()
        {
        }
    }
}
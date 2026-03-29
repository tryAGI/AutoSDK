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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ReturnVoiceProviderJsonConverter))]
        public global::G.ReturnVoiceProvider? Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_on")]
        public long? CreatedOn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modified_on")]
        public long? ModifiedOn { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnVoice" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="provider"></param>
        /// <param name="createdOn"></param>
        /// <param name="modifiedOn"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
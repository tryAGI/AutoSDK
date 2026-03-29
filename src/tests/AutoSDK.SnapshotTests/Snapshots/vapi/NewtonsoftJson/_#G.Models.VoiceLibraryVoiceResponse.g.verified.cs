//HintName: G.Models.VoiceLibraryVoiceResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoiceLibraryVoiceResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voiceId", Required = global::Newtonsoft.Json.Required.Always)]
        public string VoiceId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("publicOwnerId")]
        public string? PublicOwnerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gender")]
        public string? Gender { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("age")]
        public object? Age { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("accent")]
        public string? Accent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceLibraryVoiceResponse" /> class.
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="name"></param>
        /// <param name="publicOwnerId"></param>
        /// <param name="description"></param>
        /// <param name="gender"></param>
        /// <param name="age"></param>
        /// <param name="accent"></param>
        public VoiceLibraryVoiceResponse(
            string voiceId,
            string name,
            string? publicOwnerId,
            string? description,
            string? gender,
            object? age,
            string? accent)
        {
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.PublicOwnerId = publicOwnerId;
            this.Description = description;
            this.Gender = gender;
            this.Age = age;
            this.Accent = accent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceLibraryVoiceResponse" /> class.
        /// </summary>
        public VoiceLibraryVoiceResponse()
        {
        }
    }
}
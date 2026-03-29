//HintName: G.Models.CloneVoiceDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CloneVoiceDTO
    {
        /// <summary>
        /// This is the name of the cloned voice in the provider account.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// This is the description of your cloned voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Serialized labels dictionary for the voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("labels")]
        public string? Labels { get; set; }

        /// <summary>
        /// These are the files you want to use to clone your voice. Only Audio files are supported.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("files", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<byte[]> Files { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CloneVoiceDTO" /> class.
        /// </summary>
        /// <param name="name">
        /// This is the name of the cloned voice in the provider account.
        /// </param>
        /// <param name="files">
        /// These are the files you want to use to clone your voice. Only Audio files are supported.
        /// </param>
        /// <param name="description">
        /// This is the description of your cloned voice.
        /// </param>
        /// <param name="labels">
        /// Serialized labels dictionary for the voice.
        /// </param>
        public CloneVoiceDTO(
            string name,
            global::System.Collections.Generic.IList<byte[]> files,
            string? description,
            string? labels)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Labels = labels;
            this.Files = files ?? throw new global::System.ArgumentNullException(nameof(files));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CloneVoiceDTO" /> class.
        /// </summary>
        public CloneVoiceDTO()
        {
        }
    }
}
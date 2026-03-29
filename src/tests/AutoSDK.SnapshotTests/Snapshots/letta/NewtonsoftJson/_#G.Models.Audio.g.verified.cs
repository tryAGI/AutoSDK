//HintName: G.Models.Audio.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Data about a previous audio response from the model.<br/>
    /// [Learn more](https://platform.openai.com/docs/guides/audio).
    /// </summary>
    public sealed partial class Audio
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Audio" /> class.
        /// </summary>
        /// <param name="id"></param>
        public Audio(
            string id)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Audio" /> class.
        /// </summary>
        public Audio()
        {
        }
    }
}
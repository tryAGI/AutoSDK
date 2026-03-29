//HintName: G.Models.AudioChunkActionData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudioChunkActionData
    {
        /// <summary>
        /// Chunk encoded in base64. The chunk must contains complete frames<br/>
        /// Example: aGVsbG8=
        /// </summary>
        /// <example>aGVsbG8=</example>
        [global::Newtonsoft.Json.JsonProperty("chunk", Required = global::Newtonsoft.Json.Required.Always)]
        public string Chunk { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioChunkActionData" /> class.
        /// </summary>
        /// <param name="chunk">
        /// Chunk encoded in base64. The chunk must contains complete frames<br/>
        /// Example: aGVsbG8=
        /// </param>
        public AudioChunkActionData(
            string chunk)
        {
            this.Chunk = chunk ?? throw new global::System.ArgumentNullException(nameof(chunk));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioChunkActionData" /> class.
        /// </summary>
        public AudioChunkActionData()
        {
        }
    }
}
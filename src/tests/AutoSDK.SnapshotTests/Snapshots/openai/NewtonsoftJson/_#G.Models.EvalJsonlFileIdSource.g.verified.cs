//HintName: G.Models.EvalJsonlFileIdSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvalJsonlFileIdSource
    {
        /// <summary>
        /// The type of jsonl source. Always `file_id`.<br/>
        /// Default Value: file_id
        /// </summary>
        /// <default>global::G.EvalJsonlFileIdSourceType.FileId</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.EvalJsonlFileIdSourceTypeJsonConverter))]
        public global::G.EvalJsonlFileIdSourceType Type { get; set; } = global::G.EvalJsonlFileIdSourceType.FileId;

        /// <summary>
        /// The identifier of the file.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalJsonlFileIdSource" /> class.
        /// </summary>
        /// <param name="id">
        /// The identifier of the file.
        /// </param>
        /// <param name="type">
        /// The type of jsonl source. Always `file_id`.<br/>
        /// Default Value: file_id
        /// </param>
        public EvalJsonlFileIdSource(
            string id,
            global::G.EvalJsonlFileIdSourceType type = global::G.EvalJsonlFileIdSourceType.FileId)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalJsonlFileIdSource" /> class.
        /// </summary>
        public EvalJsonlFileIdSource()
        {
        }
    }
}
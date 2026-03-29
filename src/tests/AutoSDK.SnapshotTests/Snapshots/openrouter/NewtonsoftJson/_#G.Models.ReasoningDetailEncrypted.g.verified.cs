//HintName: G.Models.ReasoningDetailEncrypted.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Reasoning detail encrypted schema
    /// </summary>
    public sealed partial class ReasoningDetailEncrypted
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ReasoningDetailEncryptedType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public string Data { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("format")]
        public global::G.OneOf<global::G.ReasoningDetailEncryptedFormat?, object>? Format { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index")]
        public double? Index { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningDetailEncrypted" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="format"></param>
        /// <param name="index"></param>
        public ReasoningDetailEncrypted(
            string data,
            global::G.ReasoningDetailEncryptedType type,
            string? id,
            global::G.OneOf<global::G.ReasoningDetailEncryptedFormat?, object>? format,
            double? index)
        {
            this.Type = type;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Id = id;
            this.Format = format;
            this.Index = index;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningDetailEncrypted" /> class.
        /// </summary>
        public ReasoningDetailEncrypted()
        {
        }
    }
}
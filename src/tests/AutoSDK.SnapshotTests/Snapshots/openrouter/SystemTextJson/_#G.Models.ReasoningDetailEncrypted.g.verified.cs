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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ReasoningDetailEncryptedTypeJsonConverter))]
        public global::G.ReasoningDetailEncryptedType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.ReasoningDetailEncryptedFormat?, object>))]
        public global::G.OneOf<global::G.ReasoningDetailEncryptedFormat?, object>? Format { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        public double? Index { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningDetailEncrypted" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="format"></param>
        /// <param name="index"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
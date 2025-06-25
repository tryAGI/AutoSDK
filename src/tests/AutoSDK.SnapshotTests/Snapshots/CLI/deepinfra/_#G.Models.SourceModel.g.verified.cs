//HintName: G.Models.SourceModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SourceModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SourceTypeEnumJsonConverter))]
        public global::G.SourceTypeEnum Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("civit_url")]
        public string? CivitUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceModel" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="civitUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SourceModel(
            global::G.SourceTypeEnum type,
            string? civitUrl)
        {
            this.Type = type;
            this.CivitUrl = civitUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceModel" /> class.
        /// </summary>
        public SourceModel()
        {
        }
    }
}
//HintName: G.Models.ReferencedToolCommonModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Reference to a tool for unit test evaluation.
    /// </summary>
    public sealed partial class ReferencedToolCommonModel
    {
        /// <summary>
        /// The ID of the tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The type of the tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ReferencedToolCommonModelTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ReferencedToolCommonModelType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReferencedToolCommonModel" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the tool
        /// </param>
        /// <param name="type">
        /// The type of the tool
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReferencedToolCommonModel(
            string id,
            global::G.ReferencedToolCommonModelType type)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReferencedToolCommonModel" /> class.
        /// </summary>
        public ReferencedToolCommonModel()
        {
        }
    }
}
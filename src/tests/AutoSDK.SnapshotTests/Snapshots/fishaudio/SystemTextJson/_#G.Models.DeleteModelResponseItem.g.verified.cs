//HintName: G.Models.DeleteModelResponseItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteModelResponseItem
    {
        /// <summary>
        /// error field
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("loc")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Loc { get; set; }

        /// <summary>
        /// error type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// error message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("msg")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Msg { get; set; }

        /// <summary>
        /// error context
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ctx")]
        public string? Ctx { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("in")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DeleteModelResponseItemInJsonConverter))]
        public global::G.DeleteModelResponseItemIn? In { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteModelResponseItem" /> class.
        /// </summary>
        /// <param name="loc">
        /// error field
        /// </param>
        /// <param name="type">
        /// error type
        /// </param>
        /// <param name="msg">
        /// error message
        /// </param>
        /// <param name="ctx">
        /// error context
        /// </param>
        /// <param name="in"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteModelResponseItem(
            global::System.Collections.Generic.IList<string> loc,
            string type,
            string msg,
            string? ctx,
            global::G.DeleteModelResponseItemIn? @in)
        {
            this.Loc = loc ?? throw new global::System.ArgumentNullException(nameof(loc));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Msg = msg ?? throw new global::System.ArgumentNullException(nameof(msg));
            this.Ctx = ctx;
            this.In = @in;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteModelResponseItem" /> class.
        /// </summary>
        public DeleteModelResponseItem()
        {
        }
    }
}
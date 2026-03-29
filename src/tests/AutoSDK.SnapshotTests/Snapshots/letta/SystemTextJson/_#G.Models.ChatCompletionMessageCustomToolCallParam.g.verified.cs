//HintName: G.Models.ChatCompletionMessageCustomToolCallParam.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A call to a custom tool created by the model.
    /// </summary>
    public sealed partial class ChatCompletionMessageCustomToolCallParam
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The custom tool that the model called.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CustomInput Custom { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"custom"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "custom";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionMessageCustomToolCallParam" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="custom">
        /// The custom tool that the model called.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionMessageCustomToolCallParam(
            string id,
            global::G.CustomInput custom,
            string type = "custom")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Custom = custom ?? throw new global::System.ArgumentNullException(nameof(custom));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionMessageCustomToolCallParam" /> class.
        /// </summary>
        public ChatCompletionMessageCustomToolCallParam()
        {
        }
    }
}
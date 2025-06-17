//HintName: G.Models.ToolCallV2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An array of tool calls to be made.
    /// </summary>
    public sealed partial class ToolCallV2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function")]
        public global::G.ToolCallV2Function? Function { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ToolCallV2TypeJsonConverter))]
        public global::G.ToolCallV2Type? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallV2" /> class.
        /// </summary>
        /// <param name="function"></param>
        /// <param name="id"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolCallV2(
            global::G.ToolCallV2Function? function,
            string? id,
            global::G.ToolCallV2Type? type)
        {
            this.Function = function;
            this.Id = id;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallV2" /> class.
        /// </summary>
        public ToolCallV2()
        {
        }
    }
}
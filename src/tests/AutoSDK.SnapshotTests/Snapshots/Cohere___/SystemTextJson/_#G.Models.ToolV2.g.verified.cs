//HintName: G.Models.ToolV2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolV2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ToolV2TypeJsonConverter))]
        public global::G.ToolV2Type? Type { get; set; }

        /// <summary>
        /// The function to be executed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function")]
        public global::G.ToolV2Function? Function { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolV2" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="function">
        /// The function to be executed.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ToolV2(
            global::G.ToolV2Type? type,
            global::G.ToolV2Function? function)
        {
            this.Type = type;
            this.Function = function;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolV2" /> class.
        /// </summary>
        public ToolV2()
        {
        }
    }
}
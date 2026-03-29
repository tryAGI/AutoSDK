//HintName: G.Models.ApplyPatchServerTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Apply patch tool configuration
    /// </summary>
    public sealed partial class ApplyPatchServerTool
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ApplyPatchServerToolTypeJsonConverter))]
        public global::G.ApplyPatchServerToolType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplyPatchServerTool" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApplyPatchServerTool(
            global::G.ApplyPatchServerToolType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplyPatchServerTool" /> class.
        /// </summary>
        public ApplyPatchServerTool()
        {
        }
    }
}
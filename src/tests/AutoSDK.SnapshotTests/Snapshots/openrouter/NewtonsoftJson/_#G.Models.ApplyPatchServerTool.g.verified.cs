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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ApplyPatchServerToolType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplyPatchServerTool" /> class.
        /// </summary>
        /// <param name="type"></param>
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
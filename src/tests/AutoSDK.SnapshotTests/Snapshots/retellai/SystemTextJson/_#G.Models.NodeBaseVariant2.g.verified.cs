//HintName: G.Models.NodeBaseVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NodeBaseVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_choice")]
        public global::G.ModelChoiceCascading? ModelChoice { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeBaseVariant2" /> class.
        /// </summary>
        /// <param name="modelChoice"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NodeBaseVariant2(
            global::G.ModelChoiceCascading? modelChoice)
        {
            this.ModelChoice = modelChoice;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeBaseVariant2" /> class.
        /// </summary>
        public NodeBaseVariant2()
        {
        }
    }
}
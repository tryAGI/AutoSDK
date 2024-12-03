//HintName: G.Models.ChatToolPlanDeltaEventVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatToolPlanDeltaEventVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        public global::G.ChatToolPlanDeltaEventVariant2Delta? Delta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatToolPlanDeltaEventVariant2" /> class.
        /// </summary>
        /// <param name="delta"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ChatToolPlanDeltaEventVariant2(
            global::G.ChatToolPlanDeltaEventVariant2Delta? delta)
        {
            this.Delta = delta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatToolPlanDeltaEventVariant2" /> class.
        /// </summary>
        public ChatToolPlanDeltaEventVariant2()
        {
        }
    }
}
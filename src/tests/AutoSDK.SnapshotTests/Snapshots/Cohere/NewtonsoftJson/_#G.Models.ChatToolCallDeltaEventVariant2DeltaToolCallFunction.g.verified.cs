//HintName: G.Models.ChatToolCallDeltaEventVariant2DeltaToolCallFunction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatToolCallDeltaEventVariant2DeltaToolCallFunction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("arguments")]
        public string? Arguments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatToolCallDeltaEventVariant2DeltaToolCallFunction" /> class.
        /// </summary>
        /// <param name="arguments"></param>
        public ChatToolCallDeltaEventVariant2DeltaToolCallFunction(
            string? arguments)
        {
            this.Arguments = arguments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatToolCallDeltaEventVariant2DeltaToolCallFunction" /> class.
        /// </summary>
        public ChatToolCallDeltaEventVariant2DeltaToolCallFunction()
        {
        }
    }
}
//HintName: G.Models.ChatToolCallStartEventVariant2DeltaToolCallFunction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatToolCallStartEventVariant2DeltaToolCallFunction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public string? Arguments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatToolCallStartEventVariant2DeltaToolCallFunction" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="arguments"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ChatToolCallStartEventVariant2DeltaToolCallFunction(
            string? name,
            string? arguments)
        {
            this.Name = name;
            this.Arguments = arguments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatToolCallStartEventVariant2DeltaToolCallFunction" /> class.
        /// </summary>
        public ChatToolCallStartEventVariant2DeltaToolCallFunction()
        {
        }
    }
}
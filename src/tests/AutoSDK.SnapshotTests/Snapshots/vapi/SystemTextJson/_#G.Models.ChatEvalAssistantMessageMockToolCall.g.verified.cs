//HintName: G.Models.ChatEvalAssistantMessageMockToolCall.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatEvalAssistantMessageMockToolCall
    {
        /// <summary>
        /// This is the name of the tool that will be called.<br/>
        /// It should be one of the tools created in the organization.<br/>
        /// Example: get_weather
        /// </summary>
        /// <example>get_weather</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// This is the arguments that will be passed to the tool call.<br/>
        /// Example: "{"city": "San Francisco"}"
        /// </summary>
        /// <example>"{"city": "San Francisco"}"</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public object? Arguments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatEvalAssistantMessageMockToolCall" /> class.
        /// </summary>
        /// <param name="name">
        /// This is the name of the tool that will be called.<br/>
        /// It should be one of the tools created in the organization.<br/>
        /// Example: get_weather
        /// </param>
        /// <param name="arguments">
        /// This is the arguments that will be passed to the tool call.<br/>
        /// Example: "{"city": "San Francisco"}"
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatEvalAssistantMessageMockToolCall(
            string name,
            object? arguments)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Arguments = arguments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatEvalAssistantMessageMockToolCall" /> class.
        /// </summary>
        public ChatEvalAssistantMessageMockToolCall()
        {
        }
    }
}
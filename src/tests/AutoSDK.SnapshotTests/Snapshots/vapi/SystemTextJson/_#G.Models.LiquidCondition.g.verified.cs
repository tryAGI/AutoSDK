//HintName: G.Models.LiquidCondition.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LiquidCondition
    {
        /// <summary>
        /// This is the type discriminator for liquid condition<br/>
        /// Example: liquid
        /// </summary>
        /// <example>liquid</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.LiquidConditionTypeJsonConverter))]
        public global::G.LiquidConditionType Type { get; set; }

        /// <summary>
        /// This is the Liquid template that must return exactly "true" or "false" as a string.<br/>
        /// The template is evaluated and the entire output must be either "true" or "false" - nothing else.<br/>
        /// Available variables:<br/>
        /// - `messages`: Array of recent messages in OpenAI chat completions format (ChatCompletionMessageParam[])<br/>
        ///   Each message has properties like: role ('user', 'assistant', 'system'), content (string), etc.<br/>
        /// - `now`: Current timestamp in milliseconds (built-in Liquid variable)<br/>
        /// - Any assistant variable values (e.g., `userName`, `accountStatus`)<br/>
        /// Useful Liquid filters for messages:<br/>
        /// - `messages | last: 5` - Get the 5 most recent messages<br/>
        /// - `messages | where: 'role', 'user'` - Filter to only user messages<br/>
        /// - `messages | reverse` - Reverse the order of messages
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("liquid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Liquid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiquidCondition" /> class.
        /// </summary>
        /// <param name="liquid">
        /// This is the Liquid template that must return exactly "true" or "false" as a string.<br/>
        /// The template is evaluated and the entire output must be either "true" or "false" - nothing else.<br/>
        /// Available variables:<br/>
        /// - `messages`: Array of recent messages in OpenAI chat completions format (ChatCompletionMessageParam[])<br/>
        ///   Each message has properties like: role ('user', 'assistant', 'system'), content (string), etc.<br/>
        /// - `now`: Current timestamp in milliseconds (built-in Liquid variable)<br/>
        /// - Any assistant variable values (e.g., `userName`, `accountStatus`)<br/>
        /// Useful Liquid filters for messages:<br/>
        /// - `messages | last: 5` - Get the 5 most recent messages<br/>
        /// - `messages | where: 'role', 'user'` - Filter to only user messages<br/>
        /// - `messages | reverse` - Reverse the order of messages
        /// </param>
        /// <param name="type">
        /// This is the type discriminator for liquid condition<br/>
        /// Example: liquid
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiquidCondition(
            string liquid,
            global::G.LiquidConditionType type)
        {
            this.Type = type;
            this.Liquid = liquid ?? throw new global::System.ArgumentNullException(nameof(liquid));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiquidCondition" /> class.
        /// </summary>
        public LiquidCondition()
        {
        }
    }
}
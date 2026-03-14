//HintName: G.Models.ThinkingEventVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ThinkingEventVariant2
    {
        /// <summary>
        /// The type of event.<br/>
        /// Default Value: thinking
        /// </summary>
        /// <default>"thinking"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "thinking";

        /// <summary>
        /// Human-readable content of the reasoning process.<br/>
        /// Example: Analyzing user request and considering available options
        /// </summary>
        /// <example>Analyzing user request and considering available options</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ThinkingEventVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of event.<br/>
        /// Default Value: thinking
        /// </param>
        /// <param name="content">
        /// Human-readable content of the reasoning process.<br/>
        /// Example: Analyzing user request and considering available options
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ThinkingEventVariant2(
            string type,
            string? content)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThinkingEventVariant2" /> class.
        /// </summary>
        public ThinkingEventVariant2()
        {
        }
    }
}
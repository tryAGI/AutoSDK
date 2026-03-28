//HintName: G.Models.PostDialDigitsDynamicVariable.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostDialDigitsDynamicVariable
    {
        /// <summary>
        /// Default Value: dynamic
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The dynamic variable name to resolve
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostDialDigitsDynamicVariable" /> class.
        /// </summary>
        /// <param name="value">
        /// The dynamic variable name to resolve
        /// </param>
        /// <param name="type">
        /// Default Value: dynamic
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostDialDigitsDynamicVariable(
            string value,
            string? type)
        {
            this.Type = type;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostDialDigitsDynamicVariable" /> class.
        /// </summary>
        public PostDialDigitsDynamicVariable()
        {
        }
    }
}
//HintName: G.Models.PostDialDigitsStatic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostDialDigitsStatic
    {
        /// <summary>
        /// Default Value: static
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// DTMF digits to send after call connects (e.g., 'ww1234' for extension)
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
        /// Initializes a new instance of the <see cref="PostDialDigitsStatic" /> class.
        /// </summary>
        /// <param name="value">
        /// DTMF digits to send after call connects (e.g., 'ww1234' for extension)
        /// </param>
        /// <param name="type">
        /// Default Value: static
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostDialDigitsStatic(
            string value,
            string? type)
        {
            this.Type = type;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostDialDigitsStatic" /> class.
        /// </summary>
        public PostDialDigitsStatic()
        {
        }
    }
}
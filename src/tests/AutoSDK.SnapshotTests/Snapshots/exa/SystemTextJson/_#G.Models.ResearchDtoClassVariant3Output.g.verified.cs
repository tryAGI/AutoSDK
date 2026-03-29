//HintName: G.Models.ResearchDtoClassVariant3Output.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchDtoClassVariant3Output
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parsed")]
        public object? Parsed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassVariant3Output" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="parsed"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchDtoClassVariant3Output(
            string content,
            object? parsed)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Parsed = parsed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassVariant3Output" /> class.
        /// </summary>
        public ResearchDtoClassVariant3Output()
        {
        }
    }
}
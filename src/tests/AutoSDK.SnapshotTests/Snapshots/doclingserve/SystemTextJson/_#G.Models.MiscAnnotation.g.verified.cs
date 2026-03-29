//HintName: G.Models.MiscAnnotation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// MiscAnnotation.
    /// </summary>
    public sealed partial class MiscAnnotation
    {
        /// <summary>
        /// Default Value: misc
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        public string? Kind { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MiscAnnotation" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="kind">
        /// Default Value: misc
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MiscAnnotation(
            object content,
            string? kind)
        {
            this.Kind = kind;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MiscAnnotation" /> class.
        /// </summary>
        public MiscAnnotation()
        {
        }
    }
}
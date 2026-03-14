//HintName: G.Models.StructuredIndexingToolVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StructuredIndexingToolVariant2
    {
        /// <summary>
        /// This should always be `structured_indexing`.<br/>
        /// Default Value: structured_indexing<br/>
        /// Example: structured_indexing
        /// </summary>
        /// <default>"structured_indexing"</default>
        /// <example>structured_indexing</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "structured_indexing";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StructuredIndexingToolVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// This should always be `structured_indexing`.<br/>
        /// Default Value: structured_indexing<br/>
        /// Example: structured_indexing
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StructuredIndexingToolVariant2(
            string type)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StructuredIndexingToolVariant2" /> class.
        /// </summary>
        public StructuredIndexingToolVariant2()
        {
        }
    }
}
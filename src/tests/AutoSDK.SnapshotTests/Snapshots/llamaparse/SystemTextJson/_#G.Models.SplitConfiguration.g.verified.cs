//HintName: G.Models.SplitConfiguration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Split configuration with categories and splitting strategy.
    /// </summary>
    public sealed partial class SplitConfiguration
    {
        /// <summary>
        /// Categories to split documents into.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("categories")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.SplitCategory> Categories { get; set; }

        /// <summary>
        /// Strategy for splitting documents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("splitting_strategy")]
        public global::G.SplitStrategy? SplittingStrategy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SplitConfiguration" /> class.
        /// </summary>
        /// <param name="categories">
        /// Categories to split documents into.
        /// </param>
        /// <param name="splittingStrategy">
        /// Strategy for splitting documents.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SplitConfiguration(
            global::System.Collections.Generic.IList<global::G.SplitCategory> categories,
            global::G.SplitStrategy? splittingStrategy)
        {
            this.Categories = categories ?? throw new global::System.ArgumentNullException(nameof(categories));
            this.SplittingStrategy = splittingStrategy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SplitConfiguration" /> class.
        /// </summary>
        public SplitConfiguration()
        {
        }
    }
}
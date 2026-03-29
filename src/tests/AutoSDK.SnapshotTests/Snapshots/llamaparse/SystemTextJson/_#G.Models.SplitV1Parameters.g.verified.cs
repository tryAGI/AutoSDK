//HintName: G.Models.SplitV1Parameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Typed parameters for a *split v1* product configuration.
    /// </summary>
    public sealed partial class SplitV1Parameters
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
        /// Product type.
        /// </summary>
        /// <default>"split_v1"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("product_type")]
        public string ProductType { get; set; } = "split_v1";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SplitV1Parameters" /> class.
        /// </summary>
        /// <param name="categories">
        /// Categories to split documents into.
        /// </param>
        /// <param name="splittingStrategy">
        /// Strategy for splitting documents.
        /// </param>
        /// <param name="productType">
        /// Product type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SplitV1Parameters(
            global::System.Collections.Generic.IList<global::G.SplitCategory> categories,
            global::G.SplitStrategy? splittingStrategy,
            string productType = "split_v1")
        {
            this.Categories = categories ?? throw new global::System.ArgumentNullException(nameof(categories));
            this.SplittingStrategy = splittingStrategy;
            this.ProductType = productType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SplitV1Parameters" /> class.
        /// </summary>
        public SplitV1Parameters()
        {
        }
    }
}
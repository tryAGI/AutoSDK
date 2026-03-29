//HintName: G.Models.AuthorTokens.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AuthorTokens
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Author { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalTokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("percentage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Percentage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorTokens" /> class.
        /// </summary>
        /// <param name="author"></param>
        /// <param name="totalTokens"></param>
        /// <param name="percentage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthorTokens(
            string author,
            double totalTokens,
            double percentage)
        {
            this.Author = author ?? throw new global::System.ArgumentNullException(nameof(author));
            this.TotalTokens = totalTokens;
            this.Percentage = percentage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorTokens" /> class.
        /// </summary>
        public AuthorTokens()
        {
        }
    }
}
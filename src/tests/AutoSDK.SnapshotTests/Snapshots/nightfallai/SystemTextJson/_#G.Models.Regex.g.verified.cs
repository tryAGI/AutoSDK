//HintName: G.Models.Regex.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Regex
    {
        /// <summary>
        /// Regular expression pattern
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pattern")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Pattern { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isCaseSensitive")]
        public bool? IsCaseSensitive { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Regex" /> class.
        /// </summary>
        /// <param name="pattern">
        /// Regular expression pattern
        /// </param>
        /// <param name="isCaseSensitive">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Regex(
            string pattern,
            bool? isCaseSensitive)
        {
            this.Pattern = pattern ?? throw new global::System.ArgumentNullException(nameof(pattern));
            this.IsCaseSensitive = isCaseSensitive;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Regex" /> class.
        /// </summary>
        public Regex()
        {
        }
    }
}
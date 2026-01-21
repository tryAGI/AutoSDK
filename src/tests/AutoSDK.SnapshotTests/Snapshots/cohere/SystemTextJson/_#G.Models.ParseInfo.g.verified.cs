//HintName: G.Models.ParseInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Included only in requests
    /// </summary>
    public sealed partial class ParseInfo
    {
        /// <summary>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("separator")]
        public string? Separator { get; set; }

        /// <summary>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delimiter")]
        public string? Delimiter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseInfo" /> class.
        /// </summary>
        /// <param name="separator">
        /// Included only in requests
        /// </param>
        /// <param name="delimiter">
        /// Included only in requests
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ParseInfo(
            string? separator,
            string? delimiter)
        {
            this.Separator = separator;
            this.Delimiter = delimiter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseInfo" /> class.
        /// </summary>
        public ParseInfo()
        {
        }
    }
}
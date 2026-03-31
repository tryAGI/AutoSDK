//HintName: G.Models.ResultWithContentVariant2Extras.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Results from extras.
    /// </summary>
    public sealed partial class ResultWithContentVariant2Extras
    {
        /// <summary>
        /// Array of links from the search result.<br/>
        /// Example: []
        /// </summary>
        /// <example>[]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("links")]
        public global::System.Collections.Generic.IList<string>? Links { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultWithContentVariant2Extras" /> class.
        /// </summary>
        /// <param name="links">
        /// Array of links from the search result.<br/>
        /// Example: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResultWithContentVariant2Extras(
            global::System.Collections.Generic.IList<string>? links)
        {
            this.Links = links;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultWithContentVariant2Extras" /> class.
        /// </summary>
        public ResultWithContentVariant2Extras()
        {
        }
    }
}
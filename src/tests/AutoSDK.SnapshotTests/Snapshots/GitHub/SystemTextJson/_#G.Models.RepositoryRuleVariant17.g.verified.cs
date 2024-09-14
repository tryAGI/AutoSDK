//HintName: G.Models.RepositoryRuleVariant17.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Note: file_extension_restriction is in beta and subject to change.<br/>
    /// Prevent commits that include files with specified file extensions from being pushed to the commit graph.
    /// </summary>
    public sealed partial class RepositoryRuleVariant17
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RepositoryRuleVariant17TypeJsonConverter))]
        public global::G.RepositoryRuleVariant17Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::G.RepositoryRuleVariant17Parameters? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
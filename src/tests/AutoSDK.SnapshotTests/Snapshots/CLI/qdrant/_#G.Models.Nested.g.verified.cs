//HintName: G.Models.Nested.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Select points with payload for a specified nested field
    /// </summary>
    public sealed partial class Nested
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Filter Filter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Nested" /> class.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="filter"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Nested(
            string key,
            global::G.Filter filter)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Filter = filter ?? throw new global::System.ArgumentNullException(nameof(filter));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Nested" /> class.
        /// </summary>
        public Nested()
        {
        }
    }
}
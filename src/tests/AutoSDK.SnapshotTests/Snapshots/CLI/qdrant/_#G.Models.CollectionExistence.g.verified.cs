//HintName: G.Models.CollectionExistence.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of existence of a collection, true = exists, false = does not exist
    /// </summary>
    public sealed partial class CollectionExistence
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exists")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Exists { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionExistence" /> class.
        /// </summary>
        /// <param name="exists"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CollectionExistence(
            bool exists)
        {
            this.Exists = exists;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionExistence" /> class.
        /// </summary>
        public CollectionExistence()
        {
        }
    }
}
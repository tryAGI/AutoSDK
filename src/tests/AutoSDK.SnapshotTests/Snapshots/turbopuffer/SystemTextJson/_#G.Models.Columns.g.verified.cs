//HintName: G.Models.Columns.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A list of documents in columnar format. Each key is a column name, mapped to an array of values for that column.
    /// </summary>
    public sealed partial class Columns
    {
        /// <summary>
        /// The IDs of the documents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Id> Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::G.Vector2>, global::G.Vector2?>))]
        public global::G.OneOf<global::System.Collections.Generic.IList<global::G.Vector2>, global::G.Vector2?>? Vector { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Columns" /> class.
        /// </summary>
        /// <param name="id">
        /// The IDs of the documents.
        /// </param>
        /// <param name="vector"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Columns(
            global::System.Collections.Generic.IList<global::G.Id> id,
            global::G.OneOf<global::System.Collections.Generic.IList<global::G.Vector2>, global::G.Vector2?>? vector)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Vector = vector;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Columns" /> class.
        /// </summary>
        public Columns()
        {
        }
    }
}
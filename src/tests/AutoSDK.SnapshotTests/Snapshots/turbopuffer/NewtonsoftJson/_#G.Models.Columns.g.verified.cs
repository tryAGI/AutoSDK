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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Id> Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vector")]
        public global::G.OneOf<global::System.Collections.Generic.IList<global::G.Vector2>, global::G.Vector2?>? Vector { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Columns" /> class.
        /// </summary>
        /// <param name="id">
        /// The IDs of the documents.
        /// </param>
        /// <param name="vector"></param>
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
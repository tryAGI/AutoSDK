//HintName: G.Models.IndexesCreateResponse201.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IndexesCreateResponse201
    {
        /// <summary>
        /// Represents the unique identifier of the `index` object.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("_id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexesCreateResponse201" /> class.
        /// </summary>
        /// <param name="id">
        /// Represents the unique identifier of the `index` object.
        /// </param>
        public IndexesCreateResponse201(
            string? id)
        {
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexesCreateResponse201" /> class.
        /// </summary>
        public IndexesCreateResponse201()
        {
        }
    }
}
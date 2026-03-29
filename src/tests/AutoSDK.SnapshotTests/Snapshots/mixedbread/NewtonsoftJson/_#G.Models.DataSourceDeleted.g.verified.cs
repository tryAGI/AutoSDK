//HintName: G.Models.DataSourceDeleted.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Deleted data source.
    /// </summary>
    public sealed partial class DataSourceDeleted
    {
        /// <summary>
        /// The ID of the data source
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Whether the data source was deleted<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deleted")]
        public bool? Deleted { get; set; }

        /// <summary>
        /// The type of the object<br/>
        /// Default Value: data_source
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSourceDeleted" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the data source
        /// </param>
        /// <param name="deleted">
        /// Whether the data source was deleted<br/>
        /// Default Value: true
        /// </param>
        /// <param name="object">
        /// The type of the object<br/>
        /// Default Value: data_source
        /// </param>
        public DataSourceDeleted(
            string id,
            bool? deleted,
            string? @object)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Deleted = deleted;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSourceDeleted" /> class.
        /// </summary>
        public DataSourceDeleted()
        {
        }
    }
}
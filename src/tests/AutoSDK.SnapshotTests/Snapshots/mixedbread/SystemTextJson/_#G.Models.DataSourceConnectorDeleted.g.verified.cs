//HintName: G.Models.DataSourceConnectorDeleted.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Deleted connector.
    /// </summary>
    public sealed partial class DataSourceConnectorDeleted
    {
        /// <summary>
        /// The ID of the connector
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Whether the connector was deleted<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        public bool? Deleted { get; set; }

        /// <summary>
        /// The type of the object<br/>
        /// Default Value: data_source.connector
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSourceConnectorDeleted" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the connector
        /// </param>
        /// <param name="deleted">
        /// Whether the connector was deleted<br/>
        /// Default Value: true
        /// </param>
        /// <param name="object">
        /// The type of the object<br/>
        /// Default Value: data_source.connector
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DataSourceConnectorDeleted(
            string id,
            bool? deleted,
            string? @object)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Deleted = deleted;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSourceConnectorDeleted" /> class.
        /// </summary>
        public DataSourceConnectorDeleted()
        {
        }
    }
}
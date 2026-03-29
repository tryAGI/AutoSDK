//HintName: G.Models.DocumentStoreLoaderForUpsertRecordManager.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DocumentStoreLoaderForUpsertRecordManager
    {
        /// <summary>
        /// Name of the record manager (camelCase)<br/>
        /// Example: postgresRecordManager
        /// </summary>
        /// <example>postgresRecordManager</example>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Configuration for the record manager
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config")]
        public object? Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentStoreLoaderForUpsertRecordManager" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the record manager (camelCase)<br/>
        /// Example: postgresRecordManager
        /// </param>
        /// <param name="config">
        /// Configuration for the record manager
        /// </param>
        public DocumentStoreLoaderForUpsertRecordManager(
            string? name,
            object? config)
        {
            this.Name = name;
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentStoreLoaderForUpsertRecordManager" /> class.
        /// </summary>
        public DocumentStoreLoaderForUpsertRecordManager()
        {
        }
    }
}
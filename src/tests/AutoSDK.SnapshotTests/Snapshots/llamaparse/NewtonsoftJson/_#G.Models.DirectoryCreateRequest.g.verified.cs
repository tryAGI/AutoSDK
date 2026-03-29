//HintName: G.Models.DirectoryCreateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// API request schema for creating a directory.
    /// </summary>
    public sealed partial class DirectoryCreateRequest
    {
        /// <summary>
        /// Human-readable name for the directory.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Optional description shown to users.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Optional data source id the directory syncs from.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data_source_id")]
        public string? DataSourceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectoryCreateRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Human-readable name for the directory.
        /// </param>
        /// <param name="description">
        /// Optional description shown to users.
        /// </param>
        /// <param name="dataSourceId">
        /// Optional data source id the directory syncs from.
        /// </param>
        public DirectoryCreateRequest(
            string name,
            string? description,
            string? dataSourceId)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.DataSourceId = dataSourceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectoryCreateRequest" /> class.
        /// </summary>
        public DirectoryCreateRequest()
        {
        }
    }
}
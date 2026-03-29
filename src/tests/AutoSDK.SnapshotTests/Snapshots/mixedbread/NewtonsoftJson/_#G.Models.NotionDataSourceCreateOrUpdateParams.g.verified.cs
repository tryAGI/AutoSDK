//HintName: G.Models.NotionDataSourceCreateOrUpdateParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parameters for creating or updating a Notion data source.
    /// </summary>
    public sealed partial class NotionDataSourceCreateOrUpdateParams
    {
        /// <summary>
        /// The type of data source to create<br/>
        /// Default Value: notion
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The name of the data source
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The metadata of the data source
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// The authentication parameters of the data source. Notion supports OAuth2 and API key.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auth_params")]
        public global::G.AuthParamsVariant13? AuthParams { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NotionDataSourceCreateOrUpdateParams" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the data source
        /// </param>
        /// <param name="type">
        /// The type of data source to create<br/>
        /// Default Value: notion
        /// </param>
        /// <param name="metadata">
        /// The metadata of the data source
        /// </param>
        /// <param name="authParams">
        /// The authentication parameters of the data source. Notion supports OAuth2 and API key.
        /// </param>
        public NotionDataSourceCreateOrUpdateParams(
            string name,
            string? type,
            object? metadata,
            global::G.AuthParamsVariant13? authParams)
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Metadata = metadata;
            this.AuthParams = authParams;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotionDataSourceCreateOrUpdateParams" /> class.
        /// </summary>
        public NotionDataSourceCreateOrUpdateParams()
        {
        }
    }
}
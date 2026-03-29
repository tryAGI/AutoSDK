//HintName: G.Models.DatasetItemStreamRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetItemStreamRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DatasetName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_retrieved_id")]
        public global::System.Guid? LastRetrievedId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steam_limit")]
        public int? SteamLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_version")]
        public string? DatasetVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_name")]
        public string? ProjectName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public string? Filters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetItemStreamRequest" /> class.
        /// </summary>
        /// <param name="datasetName"></param>
        /// <param name="lastRetrievedId"></param>
        /// <param name="steamLimit"></param>
        /// <param name="datasetVersion"></param>
        /// <param name="projectName"></param>
        /// <param name="filters"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetItemStreamRequest(
            string datasetName,
            global::System.Guid? lastRetrievedId,
            int? steamLimit,
            string? datasetVersion,
            string? projectName,
            string? filters)
        {
            this.DatasetName = datasetName ?? throw new global::System.ArgumentNullException(nameof(datasetName));
            this.LastRetrievedId = lastRetrievedId;
            this.SteamLimit = steamLimit;
            this.DatasetVersion = datasetVersion;
            this.ProjectName = projectName;
            this.Filters = filters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetItemStreamRequest" /> class.
        /// </summary>
        public DatasetItemStreamRequest()
        {
        }
    }
}
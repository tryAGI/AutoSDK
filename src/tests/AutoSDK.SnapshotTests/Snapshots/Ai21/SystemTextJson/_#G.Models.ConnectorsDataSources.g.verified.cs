//HintName: G.Models.ConnectorsDataSources.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConnectorsDataSources
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_sources")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.DataSourceMetadata> DataSources { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorsDataSources" /> class.
        /// </summary>
        /// <param name="dataSources"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ConnectorsDataSources(
            global::System.Collections.Generic.IList<global::G.DataSourceMetadata> dataSources)
        {
            this.DataSources = dataSources ?? throw new global::System.ArgumentNullException(nameof(dataSources));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorsDataSources" /> class.
        /// </summary>
        public ConnectorsDataSources()
        {
        }
    }
}
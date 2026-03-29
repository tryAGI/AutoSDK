//HintName: G.Models.DataSourceReaderVersionMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DataSourceReaderVersionMetadata
    {
        /// <summary>
        /// The version of the reader to use for this data source.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reader_version")]
        public global::G.DataSourceReaderVersionMetadataReaderVersion2? ReaderVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSourceReaderVersionMetadata" /> class.
        /// </summary>
        /// <param name="readerVersion">
        /// The version of the reader to use for this data source.
        /// </param>
        public DataSourceReaderVersionMetadata(
            global::G.DataSourceReaderVersionMetadataReaderVersion2? readerVersion)
        {
            this.ReaderVersion = readerVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSourceReaderVersionMetadata" /> class.
        /// </summary>
        public DataSourceReaderVersionMetadata()
        {
        }
    }
}
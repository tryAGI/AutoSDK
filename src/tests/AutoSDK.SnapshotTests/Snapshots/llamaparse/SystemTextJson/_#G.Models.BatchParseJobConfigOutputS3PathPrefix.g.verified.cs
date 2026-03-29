//HintName: G.Models.BatchParseJobConfigOutputS3PathPrefix.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// If specified, llamaParse will save the output to the specified path. All output file will use this 'prefix' should be a valid s3:// url
    /// </summary>
    public sealed partial class BatchParseJobConfigOutputS3PathPrefix
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
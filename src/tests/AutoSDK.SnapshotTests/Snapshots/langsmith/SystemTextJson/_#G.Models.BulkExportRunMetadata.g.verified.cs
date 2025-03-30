//HintName: G.Models.BulkExportRunMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BulkExportRunMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prefix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public global::G.BulkExportRunProgress? Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkExportRunMetadata" /> class.
        /// </summary>
        /// <param name="prefix"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="result"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BulkExportRunMetadata(
            string prefix,
            global::System.DateTime startTime,
            global::System.DateTime endTime,
            global::G.BulkExportRunProgress? result)
        {
            this.Prefix = prefix ?? throw new global::System.ArgumentNullException(nameof(prefix));
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Result = result;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkExportRunMetadata" /> class.
        /// </summary>
        public BulkExportRunMetadata()
        {
        }
    }
}
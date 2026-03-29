//HintName: G.Models.ResultSuccessMetadataRecordStringAnyData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResultSuccessMetadataRecordStringAnyData
    {
        /// <summary>
        /// Construct a type with a set of properties K of type T
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RecordStringAny Metadata { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessMetadataRecordStringAnyData" /> class.
        /// </summary>
        /// <param name="metadata">
        /// Construct a type with a set of properties K of type T
        /// </param>
        public ResultSuccessMetadataRecordStringAnyData(
            global::G.RecordStringAny metadata)
        {
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessMetadataRecordStringAnyData" /> class.
        /// </summary>
        public ResultSuccessMetadataRecordStringAnyData()
        {
        }
    }
}
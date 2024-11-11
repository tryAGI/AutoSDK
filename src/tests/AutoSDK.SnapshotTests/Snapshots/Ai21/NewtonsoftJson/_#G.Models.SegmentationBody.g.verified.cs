//HintName: G.Models.SegmentationBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This class is to be used as a common class to all Studio API requests payloads
    /// </summary>
    public sealed partial class SegmentationBody
    {
        /// <summary>
        /// An enumeration.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sourceType", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.DocumentType SourceType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source", Required = global::Newtonsoft.Json.Required.Always)]
        public string Source { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentationBody" /> class.
        /// </summary>
        /// <param name="sourceType">
        /// An enumeration.
        /// </param>
        /// <param name="source"></param>
        public SegmentationBody(
            global::G.DocumentType sourceType,
            string source)
        {
            this.SourceType = sourceType;
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentationBody" /> class.
        /// </summary>
        public SegmentationBody()
        {
        }
    }
}
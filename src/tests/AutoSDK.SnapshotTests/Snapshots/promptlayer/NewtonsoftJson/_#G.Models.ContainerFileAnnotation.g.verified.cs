//HintName: G.Models.ContainerFileAnnotation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContainerFileAnnotation
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"container_file_citation"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "container_file_citation";

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("container_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ContainerId { get; set; } = default!;

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_index")]
        public int? StartIndex { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_index")]
        public int? EndIndex { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_id")]
        public string? FileId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerFileAnnotation" /> class.
        /// </summary>
        /// <param name="containerId"></param>
        /// <param name="startIndex">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="endIndex">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="filename">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="fileId">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="type"></param>
        public ContainerFileAnnotation(
            string containerId,
            int? startIndex,
            int? endIndex,
            string? filename,
            string? fileId,
            string type = "container_file_citation")
        {
            this.Type = type;
            this.ContainerId = containerId ?? throw new global::System.ArgumentNullException(nameof(containerId));
            this.StartIndex = startIndex;
            this.EndIndex = endIndex;
            this.Filename = filename;
            this.FileId = fileId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerFileAnnotation" /> class.
        /// </summary>
        public ContainerFileAnnotation()
        {
        }
    }
}
//HintName: G.Models.RemeshRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RemeshRequest
    {
        /// <summary>
        /// ID of completed task to remesh
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_task_id")]
        public string? InputTaskId { get; set; }

        /// <summary>
        /// Public URL or data URI (.glb/.gltf/.obj/.fbx/.stl)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_url")]
        public string? ModelUrl { get; set; }

        /// <summary>
        /// Default Value: [glb]
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target_formats")]
        public global::System.Collections.Generic.IList<global::G.TargetFormatRemesh>? TargetFormats { get; set; }

        /// <summary>
        /// Default Value: triangle
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("topology")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TopologyJsonConverter))]
        public global::G.Topology? Topology { get; set; }

        /// <summary>
        /// Default Value: 30000
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target_polycount")]
        public int? TargetPolycount { get; set; }

        /// <summary>
        /// Resize to height in meters (0 = no resize)<br/>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resize_height")]
        public double? ResizeHeight { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auto_size")]
        public bool? AutoSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("origin_at")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.OriginAtJsonConverter))]
        public global::G.OriginAt? OriginAt { get; set; }

        /// <summary>
        /// Only convert format, skip remesh processing
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("convert_format_only")]
        public bool? ConvertFormatOnly { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RemeshRequest" /> class.
        /// </summary>
        /// <param name="inputTaskId">
        /// ID of completed task to remesh
        /// </param>
        /// <param name="modelUrl">
        /// Public URL or data URI (.glb/.gltf/.obj/.fbx/.stl)
        /// </param>
        /// <param name="targetFormats">
        /// Default Value: [glb]
        /// </param>
        /// <param name="topology">
        /// Default Value: triangle
        /// </param>
        /// <param name="targetPolycount">
        /// Default Value: 30000
        /// </param>
        /// <param name="resizeHeight">
        /// Resize to height in meters (0 = no resize)<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="autoSize">
        /// Default Value: false
        /// </param>
        /// <param name="originAt"></param>
        /// <param name="convertFormatOnly">
        /// Only convert format, skip remesh processing
        /// </param>
        public RemeshRequest(
            string? inputTaskId,
            string? modelUrl,
            global::System.Collections.Generic.IList<global::G.TargetFormatRemesh>? targetFormats,
            global::G.Topology? topology,
            int? targetPolycount,
            double? resizeHeight,
            bool? autoSize,
            global::G.OriginAt? originAt,
            bool? convertFormatOnly)
        {
            this.InputTaskId = inputTaskId;
            this.ModelUrl = modelUrl;
            this.TargetFormats = targetFormats;
            this.Topology = topology;
            this.TargetPolycount = targetPolycount;
            this.ResizeHeight = resizeHeight;
            this.AutoSize = autoSize;
            this.OriginAt = originAt;
            this.ConvertFormatOnly = convertFormatOnly;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemeshRequest" /> class.
        /// </summary>
        public RemeshRequest()
        {
        }
    }
}
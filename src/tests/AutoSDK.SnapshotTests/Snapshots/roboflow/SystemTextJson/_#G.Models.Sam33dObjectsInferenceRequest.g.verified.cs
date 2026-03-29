//HintName: G.Models.Sam33dObjectsInferenceRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// SAM3D inference request for 3D object generation.<br/>
    /// Attributes:<br/>
    ///     api_key (Optional[str]): Roboflow API Key.<br/>
    ///     image (InferenceRequestImage): The input image to be used for 3D generation.<br/>
    ///     mask_input: Mask(s) in any supported format - polygon, binary mask, or RLE.
    /// </summary>
    public sealed partial class Sam33dObjectsInferenceRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Roboflow API Key that will be passed to the model during initialization for artifact retrieval
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        public string? ApiKey { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_billable")]
        public bool? UsageBillable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        public double? Start { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string? Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_info")]
        public string? SourceInfo { get; set; }

        /// <summary>
        /// If true, disables model monitoring for this request<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_model_monitoring")]
        public bool? DisableModelMonitoring { get; set; }

        /// <summary>
        /// The input image to be used for 3D generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.InferenceRequestImage Image { get; set; }

        /// <summary>
        /// Mask input in any supported format: polygon [x1,y1,x2,y2,...], binary mask (base64), RLE dict, or list of these.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask_input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object MaskInput { get; set; }

        /// <summary>
        /// The model ID for SAM3_3D.<br/>
        /// Default Value: sam3-3d-objects
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        public string? ModelId { get; set; }

        /// <summary>
        /// SAM3 3D always outputs object gaussians, and can optionally output object meshes if output_meshes is True.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_meshes")]
        public bool? OutputMeshes { get; set; }

        /// <summary>
        /// Output the combined scene reconstruction in addition to individual object reconstructions.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_scene")]
        public bool? OutputScene { get; set; }

        /// <summary>
        /// Enable mesh postprocessing.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("with_mesh_postprocess")]
        public bool? WithMeshPostprocess { get; set; }

        /// <summary>
        /// Enable texture baking for meshes.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("with_texture_baking")]
        public bool? WithTextureBaking { get; set; }

        /// <summary>
        /// Use the distilled versions of the model components.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_distillations")]
        public bool? UseDistillations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Sam33dObjectsInferenceRequest" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="image">
        /// The input image to be used for 3D generation.
        /// </param>
        /// <param name="maskInput">
        /// Mask input in any supported format: polygon [x1,y1,x2,y2,...], binary mask (base64), RLE dict, or list of these.
        /// </param>
        /// <param name="apiKey">
        /// Roboflow API Key that will be passed to the model during initialization for artifact retrieval
        /// </param>
        /// <param name="usageBillable">
        /// Default Value: true
        /// </param>
        /// <param name="start"></param>
        /// <param name="source"></param>
        /// <param name="sourceInfo"></param>
        /// <param name="disableModelMonitoring">
        /// If true, disables model monitoring for this request<br/>
        /// Default Value: false
        /// </param>
        /// <param name="modelId">
        /// The model ID for SAM3_3D.<br/>
        /// Default Value: sam3-3d-objects
        /// </param>
        /// <param name="outputMeshes">
        /// SAM3 3D always outputs object gaussians, and can optionally output object meshes if output_meshes is True.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="outputScene">
        /// Output the combined scene reconstruction in addition to individual object reconstructions.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="withMeshPostprocess">
        /// Enable mesh postprocessing.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="withTextureBaking">
        /// Enable texture baking for meshes.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="useDistillations">
        /// Use the distilled versions of the model components.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Sam33dObjectsInferenceRequest(
            string id,
            global::G.InferenceRequestImage image,
            object maskInput,
            string? apiKey,
            bool? usageBillable,
            double? start,
            string? source,
            string? sourceInfo,
            bool? disableModelMonitoring,
            string? modelId,
            bool? outputMeshes,
            bool? outputScene,
            bool? withMeshPostprocess,
            bool? withTextureBaking,
            bool? useDistillations)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ApiKey = apiKey;
            this.UsageBillable = usageBillable;
            this.Start = start;
            this.Source = source;
            this.SourceInfo = sourceInfo;
            this.DisableModelMonitoring = disableModelMonitoring;
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.MaskInput = maskInput ?? throw new global::System.ArgumentNullException(nameof(maskInput));
            this.ModelId = modelId;
            this.OutputMeshes = outputMeshes;
            this.OutputScene = outputScene;
            this.WithMeshPostprocess = withMeshPostprocess;
            this.WithTextureBaking = withTextureBaking;
            this.UseDistillations = useDistillations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Sam33dObjectsInferenceRequest" /> class.
        /// </summary>
        public Sam33dObjectsInferenceRequest()
        {
        }
    }
}
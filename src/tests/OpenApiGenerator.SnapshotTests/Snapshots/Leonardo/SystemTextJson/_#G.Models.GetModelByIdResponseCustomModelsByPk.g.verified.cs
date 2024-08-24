//HintName: G.Models.GetModelByIdResponseCustomModelsByPk.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// columns and relationships of "custom_models"
    /// </summary>
    public sealed partial class GetModelByIdResponseCustomModelsByPk
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instancePrompt")]
        public string? InstancePrompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelHeight")]
        public int ModelHeight { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelWidth")]
        public int ModelWidth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public")]
        public bool Public { get; set; }

        /// <summary>
        /// The base version of stable diffusion to use if not using a custom model. v1_5 is 1.5, v2 is 2.1, if not specified it will default to v1_5. Also includes SDXL and SDXL Lightning models
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sdVersion")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.SdVersionsJsonConverter))]
        public global::G.SdVersions? SdVersion { get; set; }

        /// <summary>
        /// The status of the current task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.JobStatusJsonConverter))]
        public global::G.JobStatus? Status { get; set; }

        /// <summary>
        /// The category the most accurately reflects the model.<br/>
        /// Default Value: GENERAL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.CustomModelTypeJsonConverter))]
        public global::G.CustomModelType? Type { get; set; } = global::G.CustomModelType.GENERAL;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
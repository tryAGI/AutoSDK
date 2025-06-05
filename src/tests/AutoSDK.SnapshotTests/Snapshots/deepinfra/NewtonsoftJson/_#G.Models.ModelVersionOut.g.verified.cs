//HintName: G.Models.ModelVersionOut.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelVersionOut
    {
        /// <summary>
        /// Model Name<br/>
        /// Example: microsoft/resnet-50
        /// </summary>
        /// <example>microsoft/resnet-50</example>
        [global::Newtonsoft.Json.JsonProperty("model_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ModelName { get; set; } = default!;

        /// <summary>
        /// Version identifier<br/>
        /// Example: 06dbf5f73be4b5eca79e137e00c4825f467cd5b172c64b6c9255dc4b5a25a03a
        /// </summary>
        /// <example>06dbf5f73be4b5eca79e137e00c4825f467cd5b172c64b6c9255dc4b5a25a03a</example>
        [global::Newtonsoft.Json.JsonProperty("version", Required = global::Newtonsoft.Json.Required.Always)]
        public string Version { get; set; } = default!;

        /// <summary>
        /// Upload time<br/>
        /// Example: 2023-01-19T21:52:03.626241+00:00
        /// </summary>
        /// <example>2023-01-19T21:52:03.626241+00:00</example>
        [global::Newtonsoft.Json.JsonProperty("uploaded_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string UploadedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelVersionOut" /> class.
        /// </summary>
        /// <param name="modelName">
        /// Model Name<br/>
        /// Example: microsoft/resnet-50
        /// </param>
        /// <param name="version">
        /// Version identifier<br/>
        /// Example: 06dbf5f73be4b5eca79e137e00c4825f467cd5b172c64b6c9255dc4b5a25a03a
        /// </param>
        /// <param name="uploadedAt">
        /// Upload time<br/>
        /// Example: 2023-01-19T21:52:03.626241+00:00
        /// </param>
        public ModelVersionOut(
            string modelName,
            string version,
            string uploadedAt)
        {
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.UploadedAt = uploadedAt ?? throw new global::System.ArgumentNullException(nameof(uploadedAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelVersionOut" /> class.
        /// </summary>
        public ModelVersionOut()
        {
        }
    }
}
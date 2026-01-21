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
        /// Model Name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelName { get; set; }

        /// <summary>
        /// Version identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// Upload time
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uploaded_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UploadedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelVersionOut" /> class.
        /// </summary>
        /// <param name="modelName">
        /// Model Name
        /// </param>
        /// <param name="version">
        /// Version identifier
        /// </param>
        /// <param name="uploadedAt">
        /// Upload time
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
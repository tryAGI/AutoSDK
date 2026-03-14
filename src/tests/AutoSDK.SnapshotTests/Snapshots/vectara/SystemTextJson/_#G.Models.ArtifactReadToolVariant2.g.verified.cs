//HintName: G.Models.ArtifactReadToolVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ArtifactReadToolVariant2
    {
        /// <summary>
        /// This should always be `artifact_read`.<br/>
        /// Default Value: artifact_read<br/>
        /// Example: artifact_read
        /// </summary>
        /// <default>"artifact_read"</default>
        /// <example>artifact_read</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "artifact_read";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ArtifactReadToolVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// This should always be `artifact_read`.<br/>
        /// Default Value: artifact_read<br/>
        /// Example: artifact_read
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ArtifactReadToolVariant2(
            string type)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArtifactReadToolVariant2" /> class.
        /// </summary>
        public ArtifactReadToolVariant2()
        {
        }
    }
}
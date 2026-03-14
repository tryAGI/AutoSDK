//HintName: G.Models.ArtifactCreateToolVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ArtifactCreateToolVariant2
    {
        /// <summary>
        /// This should always be `artifact_create`.<br/>
        /// Default Value: artifact_create<br/>
        /// Example: artifact_create
        /// </summary>
        /// <default>"artifact_create"</default>
        /// <example>artifact_create</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "artifact_create";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ArtifactCreateToolVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// This should always be `artifact_create`.<br/>
        /// Default Value: artifact_create<br/>
        /// Example: artifact_create
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ArtifactCreateToolVariant2(
            string type)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArtifactCreateToolVariant2" /> class.
        /// </summary>
        public ArtifactCreateToolVariant2()
        {
        }
    }
}
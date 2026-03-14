//HintName: G.Models.ArtifactGrepToolVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ArtifactGrepToolVariant2
    {
        /// <summary>
        /// This should always be `artifact_grep`.<br/>
        /// Default Value: artifact_grep<br/>
        /// Example: artifact_grep
        /// </summary>
        /// <default>"artifact_grep"</default>
        /// <example>artifact_grep</example>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ArtifactGrepToolVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// This should always be `artifact_grep`.<br/>
        /// Default Value: artifact_grep<br/>
        /// Example: artifact_grep
        /// </param>
        public ArtifactGrepToolVariant2(
            string type)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArtifactGrepToolVariant2" /> class.
        /// </summary>
        public ArtifactGrepToolVariant2()
        {
        }
    }
}
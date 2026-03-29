//HintName: G.Models.CreateAssetRequestConfigurationDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAssetRequestConfigurationDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateAssetRequestConfigurationDiscriminatorNameJsonConverter))]
        public global::G.CreateAssetRequestConfigurationDiscriminatorName? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAssetRequestConfigurationDiscriminator" /> class.
        /// </summary>
        /// <param name="name"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAssetRequestConfigurationDiscriminator(
            global::G.CreateAssetRequestConfigurationDiscriminatorName? name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAssetRequestConfigurationDiscriminator" /> class.
        /// </summary>
        public CreateAssetRequestConfigurationDiscriminator()
        {
        }
    }
}
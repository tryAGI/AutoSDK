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
        [global::Newtonsoft.Json.JsonProperty("name")]
        public global::G.CreateAssetRequestConfigurationDiscriminatorName? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAssetRequestConfigurationDiscriminator" /> class.
        /// </summary>
        /// <param name="name"></param>
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
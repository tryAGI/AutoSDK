//HintName: G.Models.ShotstackGeneratedAssetOptionsDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ShotstackGeneratedAssetOptionsDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ShotstackGeneratedAssetOptionsDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShotstackGeneratedAssetOptionsDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        public ShotstackGeneratedAssetOptionsDiscriminator(
            global::G.ShotstackGeneratedAssetOptionsDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShotstackGeneratedAssetOptionsDiscriminator" /> class.
        /// </summary>
        public ShotstackGeneratedAssetOptionsDiscriminator()
        {
        }
    }
}
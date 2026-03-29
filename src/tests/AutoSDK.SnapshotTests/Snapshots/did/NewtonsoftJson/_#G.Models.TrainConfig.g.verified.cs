//HintName: G.Models.TrainConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TrainConfig
    {
        /// <summary>
        /// Whether the clip is a greenscreen clip<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_greenscreen")]
        public bool? IsGreenscreen { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainConfig" /> class.
        /// </summary>
        /// <param name="isGreenscreen">
        /// Whether the clip is a greenscreen clip<br/>
        /// Default Value: false
        /// </param>
        public TrainConfig(
            bool? isGreenscreen)
        {
            this.IsGreenscreen = isGreenscreen;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainConfig" /> class.
        /// </summary>
        public TrainConfig()
        {
        }
    }
}
//HintName: G.Models.TrainClipRequestConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration options for the clip training
    /// </summary>
    public sealed partial class TrainClipRequestConfig
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
        /// Initializes a new instance of the <see cref="TrainClipRequestConfig" /> class.
        /// </summary>
        /// <param name="isGreenscreen">
        /// Whether the clip is a greenscreen clip<br/>
        /// Default Value: false
        /// </param>
        public TrainClipRequestConfig(
            bool? isGreenscreen)
        {
            this.IsGreenscreen = isGreenscreen;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainClipRequestConfig" /> class.
        /// </summary>
        public TrainClipRequestConfig()
        {
        }
    }
}
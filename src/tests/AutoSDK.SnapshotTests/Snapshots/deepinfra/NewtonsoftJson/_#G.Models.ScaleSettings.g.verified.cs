//HintName: G.Models.ScaleSettings.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScaleSettings
    {
        /// <summary>
        /// Minimum number of model instances to run<br/>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("min_instances")]
        public int? MinInstances { get; set; }

        /// <summary>
        /// Maximum number of model instances to run<br/>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_instances")]
        public int? MaxInstances { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScaleSettings" /> class.
        /// </summary>
        /// <param name="minInstances">
        /// Minimum number of model instances to run<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="maxInstances">
        /// Maximum number of model instances to run<br/>
        /// Default Value: 1
        /// </param>
        public ScaleSettings(
            int? minInstances,
            int? maxInstances)
        {
            this.MinInstances = minInstances;
            this.MaxInstances = maxInstances;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScaleSettings" /> class.
        /// </summary>
        public ScaleSettings()
        {
        }
    }
}
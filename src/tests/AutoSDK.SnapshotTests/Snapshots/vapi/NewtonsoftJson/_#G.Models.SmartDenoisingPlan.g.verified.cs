//HintName: G.Models.SmartDenoisingPlan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SmartDenoisingPlan
    {
        /// <summary>
        /// Whether smart denoising using Krisp is enabled.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SmartDenoisingPlan" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether smart denoising using Krisp is enabled.<br/>
        /// Default Value: true
        /// </param>
        public SmartDenoisingPlan(
            bool? enabled)
        {
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SmartDenoisingPlan" /> class.
        /// </summary>
        public SmartDenoisingPlan()
        {
        }
    }
}
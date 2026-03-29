//HintName: G.Models.PostedTimeoutSpecs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostedTimeoutSpecs
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inactivity")]
        public global::G.PostedTimeoutSpecsInactivity? Inactivity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_duration")]
        public global::G.PostedTimeoutSpecsMaxDuration? MaxDuration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostedTimeoutSpecs" /> class.
        /// </summary>
        /// <param name="inactivity"></param>
        /// <param name="maxDuration"></param>
        public PostedTimeoutSpecs(
            global::G.PostedTimeoutSpecsInactivity? inactivity,
            global::G.PostedTimeoutSpecsMaxDuration? maxDuration)
        {
            this.Inactivity = inactivity;
            this.MaxDuration = maxDuration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostedTimeoutSpecs" /> class.
        /// </summary>
        public PostedTimeoutSpecs()
        {
        }
    }
}
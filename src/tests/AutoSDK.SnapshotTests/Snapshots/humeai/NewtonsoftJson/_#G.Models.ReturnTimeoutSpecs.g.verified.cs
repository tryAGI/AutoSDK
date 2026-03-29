//HintName: G.Models.ReturnTimeoutSpecs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReturnTimeoutSpecs
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inactivity")]
        public global::G.ReturnTimeoutSpec? Inactivity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_duration")]
        public global::G.ReturnTimeoutSpec? MaxDuration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnTimeoutSpecs" /> class.
        /// </summary>
        /// <param name="inactivity"></param>
        /// <param name="maxDuration"></param>
        public ReturnTimeoutSpecs(
            global::G.ReturnTimeoutSpec? inactivity,
            global::G.ReturnTimeoutSpec? maxDuration)
        {
            this.Inactivity = inactivity;
            this.MaxDuration = maxDuration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnTimeoutSpecs" /> class.
        /// </summary>
        public ReturnTimeoutSpecs()
        {
        }
    }
}
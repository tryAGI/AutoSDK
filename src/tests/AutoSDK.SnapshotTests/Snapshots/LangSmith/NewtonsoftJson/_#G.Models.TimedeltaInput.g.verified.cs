//HintName: G.Models.TimedeltaInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Timedelta input.
    /// </summary>
    public sealed partial class TimedeltaInput
    {
        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("days")]
        public int? Days { get; set; } = 0;

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("minutes")]
        public int? Minutes { get; set; } = 0;

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hours")]
        public int? Hours { get; set; } = 0;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
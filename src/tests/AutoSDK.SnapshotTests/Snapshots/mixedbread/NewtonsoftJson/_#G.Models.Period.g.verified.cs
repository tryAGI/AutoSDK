//HintName: G.Models.Period.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Inclusive/exclusive window describing a billing period.
    /// </summary>
    public sealed partial class Period
    {
        /// <summary>
        /// The start of the billing period
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime Start { get; set; } = default!;

        /// <summary>
        /// The end of the billing period
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime End { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Period" /> class.
        /// </summary>
        /// <param name="start">
        /// The start of the billing period
        /// </param>
        /// <param name="end">
        /// The end of the billing period
        /// </param>
        public Period(
            global::System.DateTime start,
            global::System.DateTime end)
        {
            this.Start = start;
            this.End = end;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Period" /> class.
        /// </summary>
        public Period()
        {
        }
    }
}
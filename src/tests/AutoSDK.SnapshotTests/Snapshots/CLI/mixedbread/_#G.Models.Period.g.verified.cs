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
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Start { get; set; }

        /// <summary>
        /// The end of the billing period
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime End { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
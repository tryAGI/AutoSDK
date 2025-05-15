//HintName: G.Models.TimeInterval.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Inclusive, in ms
    /// </summary>
    public sealed partial class TimeInterval
    {
        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fr")]
        public int? Fr { get; set; }

        /// <summary>
        /// Default Value: 4000000000000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        public int? To { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeInterval" /> class.
        /// </summary>
        /// <param name="fr">
        /// Default Value: 0
        /// </param>
        /// <param name="to">
        /// Default Value: 4000000000000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TimeInterval(
            int? fr,
            int? to)
        {
            this.Fr = fr;
            this.To = to;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeInterval" /> class.
        /// </summary>
        public TimeInterval()
        {
        }
    }
}
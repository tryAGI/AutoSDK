//HintName: G.Models.GuardResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GuardResponse
    {
        /// <summary>
        /// Whether the content was flagged by any active detector.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("flagged", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Flagged { get; set; } = default!;

        /// <summary>
        /// Per-category flagging results.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("categories")]
        public global::G.Categories? Categories { get; set; }

        /// <summary>
        /// Per-message breakdown (only present when breakdown was set to true in the request).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("breakdown")]
        public global::System.Collections.Generic.IList<global::G.MessageBreakdown>? Breakdown { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardResponse" /> class.
        /// </summary>
        /// <param name="flagged">
        /// Whether the content was flagged by any active detector.
        /// </param>
        /// <param name="categories">
        /// Per-category flagging results.
        /// </param>
        /// <param name="breakdown">
        /// Per-message breakdown (only present when breakdown was set to true in the request).
        /// </param>
        public GuardResponse(
            bool flagged,
            global::G.Categories? categories,
            global::System.Collections.Generic.IList<global::G.MessageBreakdown>? breakdown)
        {
            this.Flagged = flagged;
            this.Categories = categories;
            this.Breakdown = breakdown;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardResponse" /> class.
        /// </summary>
        public GuardResponse()
        {
        }
    }
}
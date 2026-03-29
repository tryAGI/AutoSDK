//HintName: G.Models.TrackerStatusEnum2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TrackerStatusEnum2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cancelled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Cancelled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackerStatusEnum2" /> class.
        /// </summary>
        /// <param name="cancelled"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrackerStatusEnum2(
            string cancelled)
        {
            this.Cancelled = cancelled ?? throw new global::System.ArgumentNullException(nameof(cancelled));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackerStatusEnum2" /> class.
        /// </summary>
        public TrackerStatusEnum2()
        {
        }
    }
}
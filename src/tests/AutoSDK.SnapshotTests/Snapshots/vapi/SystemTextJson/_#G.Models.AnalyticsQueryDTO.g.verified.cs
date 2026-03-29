//HintName: G.Models.AnalyticsQueryDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnalyticsQueryDTO
    {
        /// <summary>
        /// This is the list of metric queries you want to perform.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queries")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.AnalyticsQuery> Queries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsQueryDTO" /> class.
        /// </summary>
        /// <param name="queries">
        /// This is the list of metric queries you want to perform.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalyticsQueryDTO(
            global::System.Collections.Generic.IList<global::G.AnalyticsQuery> queries)
        {
            this.Queries = queries ?? throw new global::System.ArgumentNullException(nameof(queries));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsQueryDTO" /> class.
        /// </summary>
        public AnalyticsQueryDTO()
        {
        }
    }
}
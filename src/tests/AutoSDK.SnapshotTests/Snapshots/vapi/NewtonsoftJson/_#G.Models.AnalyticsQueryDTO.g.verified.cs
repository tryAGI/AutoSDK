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
        [global::Newtonsoft.Json.JsonProperty("queries", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.AnalyticsQuery> Queries { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsQueryDTO" /> class.
        /// </summary>
        /// <param name="queries">
        /// This is the list of metric queries you want to perform.
        /// </param>
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
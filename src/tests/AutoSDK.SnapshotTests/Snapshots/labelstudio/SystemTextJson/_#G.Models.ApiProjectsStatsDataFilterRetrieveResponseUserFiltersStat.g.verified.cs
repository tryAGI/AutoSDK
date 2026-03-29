//HintName: G.Models.ApiProjectsStatsDataFilterRetrieveResponseUserFiltersStat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiProjectsStatsDataFilterRetrieveResponseUserFiltersStat
    {
        /// <summary>
        /// User ID or model version identifier (e.g., "model:1.0")
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsStatsDataFilterRetrieveResponseUserFiltersStat" /> class.
        /// </summary>
        /// <param name="id">
        /// User ID or model version identifier (e.g., "model:1.0")
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiProjectsStatsDataFilterRetrieveResponseUserFiltersStat(
            string? id)
        {
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsStatsDataFilterRetrieveResponseUserFiltersStat" /> class.
        /// </summary>
        public ApiProjectsStatsDataFilterRetrieveResponseUserFiltersStat()
        {
        }
    }
}
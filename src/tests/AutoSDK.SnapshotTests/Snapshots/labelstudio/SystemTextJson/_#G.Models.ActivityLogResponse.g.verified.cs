//HintName: G.Models.ActivityLogResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Serializer for ActivityLogAPI response.
    /// </summary>
    public sealed partial class ActivityLogResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ActivityLog> Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recordsFiltered")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RecordsFiltered { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recordsTotal")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RecordsTotal { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityLogResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="recordsFiltered"></param>
        /// <param name="recordsTotal"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActivityLogResponse(
            global::System.Collections.Generic.IList<global::G.ActivityLog> data,
            int recordsFiltered,
            int recordsTotal)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.RecordsFiltered = recordsFiltered;
            this.RecordsTotal = recordsTotal;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityLogResponse" /> class.
        /// </summary>
        public ActivityLogResponse()
        {
        }
    }
}
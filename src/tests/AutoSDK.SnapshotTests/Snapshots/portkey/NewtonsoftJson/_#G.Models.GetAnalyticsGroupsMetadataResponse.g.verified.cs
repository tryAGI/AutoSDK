//HintName: G.Models.GetAnalyticsGroupsMetadataResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAnalyticsGroupsMetadataResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.GetAnalyticsGroupsMetadataResponseObject Object { get; set; }

        /// <summary>
        /// Total records present across all pages
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total", Required = global::Newtonsoft.Json.Required.Always)]
        public int Total { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GetAnalyticsGroupsMetadataResponseDataItem> Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGroupsMetadataResponse" /> class.
        /// </summary>
        /// <param name="total">
        /// Total records present across all pages
        /// </param>
        /// <param name="data"></param>
        /// <param name="object"></param>
        public GetAnalyticsGroupsMetadataResponse(
            int total,
            global::System.Collections.Generic.IList<global::G.GetAnalyticsGroupsMetadataResponseDataItem> data,
            global::G.GetAnalyticsGroupsMetadataResponseObject @object)
        {
            this.Object = @object;
            this.Total = total;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGroupsMetadataResponse" /> class.
        /// </summary>
        public GetAnalyticsGroupsMetadataResponse()
        {
        }
    }
}
//HintName: G.Models.GetProvidersResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProvidersResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GetProvidersResponseObjectJsonConverter))]
        public global::G.GetProvidersResponseObject? Object { get; set; }

        /// <summary>
        /// Total number of providers
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        public int? Total { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::G.Providers>? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProvidersResponse" /> class.
        /// </summary>
        /// <param name="object"></param>
        /// <param name="total">
        /// Total number of providers
        /// </param>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProvidersResponse(
            global::G.GetProvidersResponseObject? @object,
            int? total,
            global::System.Collections.Generic.IList<global::G.Providers>? data)
        {
            this.Object = @object;
            this.Total = total;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProvidersResponse" /> class.
        /// </summary>
        public GetProvidersResponse()
        {
        }
    }
}
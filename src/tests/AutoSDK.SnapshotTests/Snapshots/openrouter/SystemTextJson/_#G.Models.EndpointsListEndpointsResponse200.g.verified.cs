//HintName: G.Models.EndpointsListEndpointsResponse200.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EndpointsListEndpointsResponse200
    {
        /// <summary>
        /// List of available endpoints for a model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ListEndpointsResponse Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EndpointsListEndpointsResponse200" /> class.
        /// </summary>
        /// <param name="data">
        /// List of available endpoints for a model
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EndpointsListEndpointsResponse200(
            global::G.ListEndpointsResponse data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EndpointsListEndpointsResponse200" /> class.
        /// </summary>
        public EndpointsListEndpointsResponse200()
        {
        }
    }
}
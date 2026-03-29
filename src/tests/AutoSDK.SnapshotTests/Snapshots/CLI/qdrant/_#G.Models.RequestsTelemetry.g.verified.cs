//HintName: G.Models.RequestsTelemetry.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RequestsTelemetry
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebApiTelemetry Rest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grpc")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GrpcTelemetry Grpc { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestsTelemetry" /> class.
        /// </summary>
        /// <param name="rest"></param>
        /// <param name="grpc"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestsTelemetry(
            global::G.WebApiTelemetry rest,
            global::G.GrpcTelemetry grpc)
        {
            this.Rest = rest ?? throw new global::System.ArgumentNullException(nameof(rest));
            this.Grpc = grpc ?? throw new global::System.ArgumentNullException(nameof(grpc));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestsTelemetry" /> class.
        /// </summary>
        public RequestsTelemetry()
        {
        }
    }
}
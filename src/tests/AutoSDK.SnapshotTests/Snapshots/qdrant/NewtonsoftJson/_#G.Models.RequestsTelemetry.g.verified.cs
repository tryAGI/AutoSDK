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
        [global::Newtonsoft.Json.JsonProperty("rest", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebApiTelemetry Rest { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("grpc", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GrpcTelemetry Grpc { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestsTelemetry" /> class.
        /// </summary>
        /// <param name="rest"></param>
        /// <param name="grpc"></param>
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
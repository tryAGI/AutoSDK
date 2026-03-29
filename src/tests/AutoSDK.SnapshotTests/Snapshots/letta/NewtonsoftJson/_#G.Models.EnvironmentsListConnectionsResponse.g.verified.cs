//HintName: G.Models.EnvironmentsListConnectionsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EnvironmentsListConnectionsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("connections", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.EnvironmentsListConnectionsResponseConnection> Connections { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hasNextPage", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasNextPage { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentsListConnectionsResponse" /> class.
        /// </summary>
        /// <param name="connections"></param>
        /// <param name="hasNextPage"></param>
        public EnvironmentsListConnectionsResponse(
            global::System.Collections.Generic.IList<global::G.EnvironmentsListConnectionsResponseConnection> connections,
            bool hasNextPage)
        {
            this.Connections = connections ?? throw new global::System.ArgumentNullException(nameof(connections));
            this.HasNextPage = hasNextPage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentsListConnectionsResponse" /> class.
        /// </summary>
        public EnvironmentsListConnectionsResponse()
        {
        }
    }
}
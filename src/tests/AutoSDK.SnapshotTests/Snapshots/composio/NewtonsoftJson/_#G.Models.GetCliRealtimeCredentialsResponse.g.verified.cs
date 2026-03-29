//HintName: G.Models.GetCliRealtimeCredentialsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetCliRealtimeCredentialsResponse
    {
        /// <summary>
        /// The Pusher client key for subscribing to the trigger
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pusher_key", Required = global::Newtonsoft.Json.Required.Always)]
        public string PusherKey { get; set; } = default!;

        /// <summary>
        /// The Pusher cluster for subscribing to the trigger
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pusher_cluster", Required = global::Newtonsoft.Json.Required.Always)]
        public string PusherCluster { get; set; } = default!;

        /// <summary>
        /// The project nanoId associated with the API Key provided. Used as part of the CLI channel name: private-cli-{project_id}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCliRealtimeCredentialsResponse" /> class.
        /// </summary>
        /// <param name="pusherKey">
        /// The Pusher client key for subscribing to the trigger
        /// </param>
        /// <param name="pusherCluster">
        /// The Pusher cluster for subscribing to the trigger
        /// </param>
        /// <param name="projectId">
        /// The project nanoId associated with the API Key provided. Used as part of the CLI channel name: private-cli-{project_id}
        /// </param>
        public GetCliRealtimeCredentialsResponse(
            string pusherKey,
            string pusherCluster,
            string projectId)
        {
            this.PusherKey = pusherKey ?? throw new global::System.ArgumentNullException(nameof(pusherKey));
            this.PusherCluster = pusherCluster ?? throw new global::System.ArgumentNullException(nameof(pusherCluster));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCliRealtimeCredentialsResponse" /> class.
        /// </summary>
        public GetCliRealtimeCredentialsResponse()
        {
        }
    }
}
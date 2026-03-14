//HintName: G.Models.VertexAccessTokenAuth.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Google Cloud Vertex AI access token authentication
    /// </summary>
    public sealed partial class VertexAccessTokenAuth
    {
        /// <summary>
        /// Must be "vertex_access_token" for access token auth<br/>
        /// Default Value: vertex_access_token<br/>
        /// Example: vertex_access_token
        /// </summary>
        /// <default>"vertex_access_token"</default>
        /// <example>vertex_access_token</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "vertex_access_token";

        /// <summary>
        /// The GCP access token<br/>
        /// Example: ya29.c.Kp...
        /// </summary>
        /// <example>ya29.c.Kp...</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AccessToken { get; set; }

        /// <summary>
        /// GCP project ID<br/>
        /// Example: my-project-id
        /// </summary>
        /// <example>my-project-id</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Project { get; set; }

        /// <summary>
        /// GCP region for Vertex AI<br/>
        /// Example: us-central1
        /// </summary>
        /// <example>us-central1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Region { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VertexAccessTokenAuth" /> class.
        /// </summary>
        /// <param name="type">
        /// Must be "vertex_access_token" for access token auth<br/>
        /// Default Value: vertex_access_token<br/>
        /// Example: vertex_access_token
        /// </param>
        /// <param name="accessToken">
        /// The GCP access token<br/>
        /// Example: ya29.c.Kp...
        /// </param>
        /// <param name="project">
        /// GCP project ID<br/>
        /// Example: my-project-id
        /// </param>
        /// <param name="region">
        /// GCP region for Vertex AI<br/>
        /// Example: us-central1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VertexAccessTokenAuth(
            string type,
            string accessToken,
            string project,
            string region)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.AccessToken = accessToken ?? throw new global::System.ArgumentNullException(nameof(accessToken));
            this.Project = project ?? throw new global::System.ArgumentNullException(nameof(project));
            this.Region = region ?? throw new global::System.ArgumentNullException(nameof(region));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VertexAccessTokenAuth" /> class.
        /// </summary>
        public VertexAccessTokenAuth()
        {
        }
    }
}
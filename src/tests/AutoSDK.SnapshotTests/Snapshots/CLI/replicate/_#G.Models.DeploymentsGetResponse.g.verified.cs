//HintName: G.Models.DeploymentsGetResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeploymentsGetResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_release")]
        public global::G.DeploymentsGetResponseCurrentRelease? CurrentRelease { get; set; }

        /// <summary>
        /// The name of the deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The owner of the deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        public string? Owner { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentsGetResponse" /> class.
        /// </summary>
        /// <param name="currentRelease"></param>
        /// <param name="name">
        /// The name of the deployment.
        /// </param>
        /// <param name="owner">
        /// The owner of the deployment.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeploymentsGetResponse(
            global::G.DeploymentsGetResponseCurrentRelease? currentRelease,
            string? name,
            string? owner)
        {
            this.CurrentRelease = currentRelease;
            this.Name = name;
            this.Owner = owner;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentsGetResponse" /> class.
        /// </summary>
        public DeploymentsGetResponse()
        {
        }
    }
}
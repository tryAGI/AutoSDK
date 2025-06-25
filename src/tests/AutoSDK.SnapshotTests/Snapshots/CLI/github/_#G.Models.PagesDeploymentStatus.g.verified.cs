//HintName: G.Models.PagesDeploymentStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PagesDeploymentStatus
    {
        /// <summary>
        /// The current status of the deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PagesDeploymentStatusStatusJsonConverter))]
        public global::G.PagesDeploymentStatusStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PagesDeploymentStatus" /> class.
        /// </summary>
        /// <param name="status">
        /// The current status of the deployment.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PagesDeploymentStatus(
            global::G.PagesDeploymentStatusStatus? status)
        {
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PagesDeploymentStatus" /> class.
        /// </summary>
        public PagesDeploymentStatus()
        {
        }
    }
}
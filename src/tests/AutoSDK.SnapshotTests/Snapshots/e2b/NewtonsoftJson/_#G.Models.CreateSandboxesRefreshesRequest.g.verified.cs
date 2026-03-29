//HintName: G.Models.CreateSandboxesRefreshesRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSandboxesRefreshesRequest
    {
        /// <summary>
        /// Duration for which the sandbox should be kept alive in seconds
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSandboxesRefreshesRequest" /> class.
        /// </summary>
        /// <param name="duration">
        /// Duration for which the sandbox should be kept alive in seconds
        /// </param>
        public CreateSandboxesRefreshesRequest(
            int? duration)
        {
            this.Duration = duration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSandboxesRefreshesRequest" /> class.
        /// </summary>
        public CreateSandboxesRefreshesRequest()
        {
        }
    }
}
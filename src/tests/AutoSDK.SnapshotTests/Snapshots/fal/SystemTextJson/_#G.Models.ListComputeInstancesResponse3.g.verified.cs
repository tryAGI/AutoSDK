//HintName: G.Models.ListComputeInstancesResponse3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Standard error response format
    /// </summary>
    public sealed partial class ListComputeInstancesResponse3
    {
        /// <summary>
        /// Error details
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ListComputeInstancesResponseError2 Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListComputeInstancesResponse3" /> class.
        /// </summary>
        /// <param name="error">
        /// Error details
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListComputeInstancesResponse3(
            global::G.ListComputeInstancesResponseError2 error)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListComputeInstancesResponse3" /> class.
        /// </summary>
        public ListComputeInstancesResponse3()
        {
        }
    }
}
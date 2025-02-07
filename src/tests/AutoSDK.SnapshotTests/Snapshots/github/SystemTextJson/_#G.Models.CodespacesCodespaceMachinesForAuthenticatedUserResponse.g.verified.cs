//HintName: G.Models.CodespacesCodespaceMachinesForAuthenticatedUserResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodespacesCodespaceMachinesForAuthenticatedUserResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("machines")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.CodespaceMachine> Machines { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodespacesCodespaceMachinesForAuthenticatedUserResponse" /> class.
        /// </summary>
        /// <param name="totalCount"></param>
        /// <param name="machines"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodespacesCodespaceMachinesForAuthenticatedUserResponse(
            int totalCount,
            global::System.Collections.Generic.IList<global::G.CodespaceMachine> machines)
        {
            this.TotalCount = totalCount;
            this.Machines = machines ?? throw new global::System.ArgumentNullException(nameof(machines));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodespacesCodespaceMachinesForAuthenticatedUserResponse" /> class.
        /// </summary>
        public CodespacesCodespaceMachinesForAuthenticatedUserResponse()
        {
        }
    }
}
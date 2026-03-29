//HintName: G.Models.PickFilterLeafUsersViewOrRequestResponseRmt.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// From T, pick a set of properties whose keys are in the union K
    /// </summary>
    public sealed partial class PickFilterLeafUsersViewOrRequestResponseRmt
    {
        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_response_rmt")]
        public global::G.PartialRequestResponseRMTToOperators? RequestResponseRmt { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("users_view")]
        public global::G.PartialUserViewToOperators? UsersView { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PickFilterLeafUsersViewOrRequestResponseRmt" /> class.
        /// </summary>
        /// <param name="requestResponseRmt">
        /// Make all properties in T optional
        /// </param>
        /// <param name="usersView">
        /// Make all properties in T optional
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PickFilterLeafUsersViewOrRequestResponseRmt(
            global::G.PartialRequestResponseRMTToOperators? requestResponseRmt,
            global::G.PartialUserViewToOperators? usersView)
        {
            this.RequestResponseRmt = requestResponseRmt;
            this.UsersView = usersView;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PickFilterLeafUsersViewOrRequestResponseRmt" /> class.
        /// </summary>
        public PickFilterLeafUsersViewOrRequestResponseRmt()
        {
        }
    }
}
//HintName: G.Models.MembershipsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MembershipsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memberships")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.MembershipResponse> Memberships { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MembershipsResponse" /> class.
        /// </summary>
        /// <param name="memberships"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MembershipsResponse(
            global::System.Collections.Generic.IList<global::G.MembershipResponse> memberships)
        {
            this.Memberships = memberships ?? throw new global::System.ArgumentNullException(nameof(memberships));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MembershipsResponse" /> class.
        /// </summary>
        public MembershipsResponse()
        {
        }
    }
}
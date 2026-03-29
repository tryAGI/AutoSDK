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
        [global::Newtonsoft.Json.JsonProperty("memberships", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.MembershipResponse> Memberships { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MembershipsResponse" /> class.
        /// </summary>
        /// <param name="memberships"></param>
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
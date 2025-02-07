//HintName: G.Models.GetUserSelfResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetUserSelfResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_details")]
        public global::System.Collections.Generic.IList<global::G.GetUserSelfResponseUserDetail>? UserDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUserSelfResponse" /> class.
        /// </summary>
        /// <param name="userDetails"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetUserSelfResponse(
            global::System.Collections.Generic.IList<global::G.GetUserSelfResponseUserDetail>? userDetails)
        {
            this.UserDetails = userDetails;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUserSelfResponse" /> class.
        /// </summary>
        public GetUserSelfResponse()
        {
        }
    }
}
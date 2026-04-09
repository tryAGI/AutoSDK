//HintName: G.Models.OpenAPIUpdateEnterpriseMemberRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAPIUpdateEnterpriseMemberRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.OpenAPIUpdateEnterpriseMemberRequestRoleJsonConverter))]
        public global::G.OpenAPIUpdateEnterpriseMemberRequestRole Role { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPIUpdateEnterpriseMemberRequest" /> class.
        /// </summary>
        /// <param name="role"></param>
        public OpenAPIUpdateEnterpriseMemberRequest(
            global::G.OpenAPIUpdateEnterpriseMemberRequestRole role)
        {
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPIUpdateEnterpriseMemberRequest" /> class.
        /// </summary>
        public OpenAPIUpdateEnterpriseMemberRequest()
        {
        }
    }
}
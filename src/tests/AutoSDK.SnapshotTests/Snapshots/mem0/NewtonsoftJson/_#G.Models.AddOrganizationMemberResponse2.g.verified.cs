//HintName: G.Models.AddOrganizationMemberResponse2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddOrganizationMemberResponse2
    {
        /// <summary>
        /// Errors found in the payload.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("errors")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? Errors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddOrganizationMemberResponse2" /> class.
        /// </summary>
        /// <param name="errors">
        /// Errors found in the payload.
        /// </param>
        public AddOrganizationMemberResponse2(
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? errors)
        {
            this.Errors = errors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddOrganizationMemberResponse2" /> class.
        /// </summary>
        public AddOrganizationMemberResponse2()
        {
        }
    }
}
//HintName: G.Models.PersonalAccessTokenRequestPermissionsAdded.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// New requested permissions, categorized by type of permission.
    /// </summary>
    public sealed partial class PersonalAccessTokenRequestPermissionsAdded
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization")]
        public global::G.PersonalAccessTokenRequestPermissionsAddedOrganization? Organization { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository")]
        public global::G.PersonalAccessTokenRequestPermissionsAddedRepository? Repository { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("other")]
        public global::G.PersonalAccessTokenRequestPermissionsAddedOther? Other { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
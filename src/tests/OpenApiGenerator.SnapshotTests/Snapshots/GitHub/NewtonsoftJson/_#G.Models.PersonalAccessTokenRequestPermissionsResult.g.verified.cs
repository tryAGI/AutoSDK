//HintName: G.Models.PersonalAccessTokenRequestPermissionsResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Permissions requested, categorized by type of permission. This field incorporates `permissions_added` and `permissions_upgraded`.
    /// </summary>
    public sealed partial class PersonalAccessTokenRequestPermissionsResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization")]
        public object? Organization { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository")]
        public object? Repository { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("other")]
        public object? Other { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
//HintName: G.Models.BetaMetadataUserId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An external identifier for the user who is associated with the request.<br/>
    /// This should be a uuid, hash value, or other opaque identifier. Anthropic may use this id to help detect abuse. Do not include any identifying information such as name, email address, or phone number.
    /// </summary>
    public sealed partial class BetaMetadataUserId
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
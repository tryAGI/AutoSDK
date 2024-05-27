﻿//HintName: G.Models.UpdateDropsEntitlementsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateDropsEntitlementsResponse
    {
        /// <summary>
        /// A list that indicates which entitlements were successfully updated and those that weren’t.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<DropsEntitlementUpdated> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
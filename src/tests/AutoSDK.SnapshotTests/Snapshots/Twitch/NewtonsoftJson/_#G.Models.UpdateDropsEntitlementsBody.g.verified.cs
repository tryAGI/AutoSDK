//HintName: G.Models.UpdateDropsEntitlementsBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateDropsEntitlementsBody
    {
        /// <summary>
        /// A list of IDs that identify the entitlements to update. You may specify a maximum of 100 IDs.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("entitlement_ids")]
        public global::System.Collections.Generic.IList<string>? EntitlementIds { get; set; }

        /// <summary>
        /// The fulfillment status to set the entitlements to. Possible values are:  <br/>
        ///   <br/>
        /// * CLAIMED — The user claimed the benefit.<br/>
        /// * FULFILLED — The developer granted the benefit that the user claimed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fulfillment_status")]
        public global::G.UpdateDropsEntitlementsBodyFulfillmentStatus? FulfillmentStatus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.UpdateDropsEntitlementsBody? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.UpdateDropsEntitlementsBody>(
                json,
                jsonSerializerOptions);
        }

    }
}
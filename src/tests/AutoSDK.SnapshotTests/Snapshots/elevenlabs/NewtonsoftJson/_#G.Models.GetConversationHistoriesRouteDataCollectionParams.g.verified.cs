//HintName: G.Models.GetConversationHistoriesRouteDataCollectionParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Data collection filters. Repeat param. Format: id:op:value where op is one of eq|neq|gt|gte|lt|lte|in|exists|missing. For in, pipe-delimit values.
    /// </summary>
    public sealed partial class GetConversationHistoriesRouteDataCollectionParams
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
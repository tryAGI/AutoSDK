//HintName: G.Models.DatasetServeRequest.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Dataset schema for serving.
    /// </summary>
    public sealed partial class DatasetServeRequest
    {
        /// <summary>
        /// Default Value: latest
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tag")]
        public global::System.AnyOf<string?, object?>? Tag { get; set; } = "latest";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
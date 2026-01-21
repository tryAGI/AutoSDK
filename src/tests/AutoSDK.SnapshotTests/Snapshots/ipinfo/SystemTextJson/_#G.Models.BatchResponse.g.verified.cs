//HintName: G.Models.BatchResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"8.8.8.8/city":"Mountain View","8.8.8.8":{"ip":"8.8.8.8","hostname":"dns.google","city":"Mountain View","region":"California","country":"US","loc":"37.4056,-122.0775","org":"AS15169 Google LLC","postal":94043,"timezone":"America/Los_Angeles"}}
    /// </summary>
    public sealed partial class BatchResponse
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
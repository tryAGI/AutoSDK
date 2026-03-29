//HintName: G.Models.CreateShardingKeyInitialState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Initial state of the shards for this key If not specified, will be `Initializing` first and then `Active` Warning: do not change this unless you know what you are doing
    /// </summary>
    public sealed partial class CreateShardingKeyInitialState
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
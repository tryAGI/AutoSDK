//HintName: G.Models.KindSerialisedDataType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Provides Python type hint for data format that should guide external clients on how to produce / consume serialised data of specific kind.
    /// </summary>
    public sealed partial class KindSerialisedDataType
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
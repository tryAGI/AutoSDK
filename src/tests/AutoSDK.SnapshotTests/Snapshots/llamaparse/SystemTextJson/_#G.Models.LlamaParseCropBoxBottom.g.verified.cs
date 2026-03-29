//HintName: G.Models.LlamaParseCropBoxBottom.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Bottom boundary as ratio (0-1). 0=top edge, 1=bottom edge. Content below this line is excluded
    /// </summary>
    public sealed partial class LlamaParseCropBoxBottom
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
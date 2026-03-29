//HintName: G.Models.DiscoverRequestTarget.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Look for vectors closest to this.<br/>
    /// When using the target (with or without context), the integer part of the score represents the rank with respect to the context, while the decimal part of the score relates to the distance to the target.
    /// </summary>
    public sealed partial class DiscoverRequestTarget
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
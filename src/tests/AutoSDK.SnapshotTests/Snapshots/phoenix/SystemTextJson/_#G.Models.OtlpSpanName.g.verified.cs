//HintName: G.Models.OtlpSpanName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A description of the span's operation.<br/>
    /// For example, the name can be a qualified method name or a file name and a line number where the operation is called. A best practice is to use the same display name at the same call point in an application. This makes it easier to correlate spans in different traces.<br/>
    /// This field is semantically required to be set to non-empty string. Empty value is equivalent to an unknown span name.<br/>
    /// This field is required.
    /// </summary>
    public sealed partial class OtlpSpanName
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
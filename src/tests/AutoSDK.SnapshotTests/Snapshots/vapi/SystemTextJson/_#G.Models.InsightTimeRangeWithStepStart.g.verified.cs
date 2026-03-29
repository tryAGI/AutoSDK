//HintName: G.Models.InsightTimeRangeWithStepStart.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the start date for the time range.<br/>
    /// Should be a valid ISO 8601 date-time string or relative time string.<br/>
    /// If not provided, defaults to the 7 days ago.<br/>
    /// Relative time strings of the format "-{number}{unit}" are allowed.<br/>
    /// Valid units are:<br/>
    /// - d: days<br/>
    /// - h: hours<br/>
    /// - w: weeks<br/>
    /// - m: months<br/>
    /// - y: years<br/>
    /// Example: "2025-01-01" or "-7d" or "now"
    /// </summary>
    public sealed partial class InsightTimeRangeWithStepStart
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
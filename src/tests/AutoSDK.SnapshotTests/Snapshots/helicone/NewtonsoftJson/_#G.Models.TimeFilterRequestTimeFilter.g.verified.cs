//HintName: G.Models.TimeFilterRequestTimeFilter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TimeFilterRequestTimeFilter
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end", Required = global::Newtonsoft.Json.Required.Always)]
        public string End { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start", Required = global::Newtonsoft.Json.Required.Always)]
        public string Start { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeFilterRequestTimeFilter" /> class.
        /// </summary>
        /// <param name="end"></param>
        /// <param name="start"></param>
        public TimeFilterRequestTimeFilter(
            string end,
            string start)
        {
            this.End = end ?? throw new global::System.ArgumentNullException(nameof(end));
            this.Start = start ?? throw new global::System.ArgumentNullException(nameof(start));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeFilterRequestTimeFilter" /> class.
        /// </summary>
        public TimeFilterRequestTimeFilter()
        {
        }
    }
}
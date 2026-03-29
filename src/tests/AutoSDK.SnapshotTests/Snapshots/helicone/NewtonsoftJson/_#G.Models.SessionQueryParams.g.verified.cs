//HintName: G.Models.SessionQueryParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SessionQueryParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("search", Required = global::Newtonsoft.Json.Required.Always)]
        public string Search { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeFilter", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SessionQueryParamsTimeFilter TimeFilter { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("nameEquals")]
        public string? NameEquals { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timezoneDifference", Required = global::Newtonsoft.Json.Required.Always)]
        public double TimezoneDifference { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filter", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SessionFilterNode Filter { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("offset")]
        public double? Offset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit")]
        public double? Limit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionQueryParams" /> class.
        /// </summary>
        /// <param name="search"></param>
        /// <param name="timeFilter"></param>
        /// <param name="timezoneDifference"></param>
        /// <param name="filter"></param>
        /// <param name="nameEquals"></param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        public SessionQueryParams(
            string search,
            global::G.SessionQueryParamsTimeFilter timeFilter,
            double timezoneDifference,
            global::G.SessionFilterNode filter,
            string? nameEquals,
            double? offset,
            double? limit)
        {
            this.Search = search ?? throw new global::System.ArgumentNullException(nameof(search));
            this.TimeFilter = timeFilter ?? throw new global::System.ArgumentNullException(nameof(timeFilter));
            this.NameEquals = nameEquals;
            this.TimezoneDifference = timezoneDifference;
            this.Filter = filter;
            this.Offset = offset;
            this.Limit = limit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionQueryParams" /> class.
        /// </summary>
        public SessionQueryParams()
        {
        }
    }
}
//HintName: G.Models.SessionNameQueryParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SessionNameQueryParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("nameContains", Required = global::Newtonsoft.Json.Required.Always)]
        public string NameContains { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timezoneDifference", Required = global::Newtonsoft.Json.Required.Always)]
        public double TimezoneDifference { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pSize")]
        public global::G.SessionNameQueryParamsPSize? PSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("useInterquartile")]
        public bool? UseInterquartile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeFilter")]
        public global::G.TimeFilterMs? TimeFilter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filter")]
        public global::G.SessionFilterNode? Filter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionNameQueryParams" /> class.
        /// </summary>
        /// <param name="nameContains"></param>
        /// <param name="timezoneDifference"></param>
        /// <param name="pSize"></param>
        /// <param name="useInterquartile"></param>
        /// <param name="timeFilter"></param>
        /// <param name="filter"></param>
        public SessionNameQueryParams(
            string nameContains,
            double timezoneDifference,
            global::G.SessionNameQueryParamsPSize? pSize,
            bool? useInterquartile,
            global::G.TimeFilterMs? timeFilter,
            global::G.SessionFilterNode? filter)
        {
            this.NameContains = nameContains ?? throw new global::System.ArgumentNullException(nameof(nameContains));
            this.TimezoneDifference = timezoneDifference;
            this.PSize = pSize;
            this.UseInterquartile = useInterquartile;
            this.TimeFilter = timeFilter;
            this.Filter = filter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionNameQueryParams" /> class.
        /// </summary>
        public SessionNameQueryParams()
        {
        }
    }
}
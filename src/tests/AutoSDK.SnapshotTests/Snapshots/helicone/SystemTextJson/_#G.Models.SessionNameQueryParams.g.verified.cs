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
        [global::System.Text.Json.Serialization.JsonPropertyName("nameContains")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NameContains { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezoneDifference")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TimezoneDifference { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pSize")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SessionNameQueryParamsPSizeJsonConverter))]
        public global::G.SessionNameQueryParamsPSize? PSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("useInterquartile")]
        public bool? UseInterquartile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeFilter")]
        public global::G.TimeFilterMs? TimeFilter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SessionFilterNodeJsonConverter))]
        public global::G.SessionFilterNode? Filter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
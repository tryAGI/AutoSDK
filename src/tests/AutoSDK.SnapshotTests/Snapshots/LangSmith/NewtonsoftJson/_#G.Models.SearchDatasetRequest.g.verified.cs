//HintName: G.Models.SearchDatasetRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Dataset schema for serving.
    /// </summary>
    public sealed partial class SearchDatasetRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputs", Required = global::Newtonsoft.Json.Required.Always)]
        public object Inputs { get; set; } = default!;

        /// <summary>
        /// Default Value: 5
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("debug")]
        public bool? Debug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filter")]
        public string? Filter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchDatasetRequest" /> class.
        /// </summary>
        /// <param name="inputs"></param>
        /// <param name="limit">
        /// Default Value: 5
        /// </param>
        /// <param name="debug">
        /// Default Value: false
        /// </param>
        /// <param name="filter"></param>
        public SearchDatasetRequest(
            object inputs,
            int? limit,
            bool? debug,
            string? filter)
        {
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
            this.Limit = limit;
            this.Debug = debug;
            this.Filter = filter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchDatasetRequest" /> class.
        /// </summary>
        public SearchDatasetRequest()
        {
        }
    }
}
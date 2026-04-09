//HintName: G.Models.ResearchOperationDtoClassVariant3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchOperationDtoClassVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ResearchOperationDtoClassVariant3TypeJsonConverter))]
        public global::G.ResearchOperationDtoClassVariant3Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("goal")]
        public string? Goal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ResearchOperationDtoClassVariant3Result Result { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pageTokens", Required = global::Newtonsoft.Json.Required.Always)]
        public double PageTokens { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchOperationDtoClassVariant3" /> class.
        /// </summary>
        /// <param name="result"></param>
        /// <param name="pageTokens"></param>
        /// <param name="type"></param>
        /// <param name="goal"></param>
        public ResearchOperationDtoClassVariant3(
            global::G.ResearchOperationDtoClassVariant3Result result,
            double pageTokens,
            global::G.ResearchOperationDtoClassVariant3Type type,
            string? goal)
        {
            this.Type = type;
            this.Goal = goal;
            this.Result = result ?? throw new global::System.ArgumentNullException(nameof(result));
            this.PageTokens = pageTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchOperationDtoClassVariant3" /> class.
        /// </summary>
        public ResearchOperationDtoClassVariant3()
        {
        }
    }
}
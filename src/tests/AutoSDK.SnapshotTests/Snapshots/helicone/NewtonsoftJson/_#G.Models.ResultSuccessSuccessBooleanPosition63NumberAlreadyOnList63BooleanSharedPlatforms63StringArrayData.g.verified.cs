//HintName: G.Models.ResultSuccessSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArrayData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResultSuccessSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArrayData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sharedPlatforms")]
        public global::System.Collections.Generic.IList<string>? SharedPlatforms { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("alreadyOnList")]
        public bool? AlreadyOnList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("position")]
        public double? Position { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("success", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Success { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArrayData" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="sharedPlatforms"></param>
        /// <param name="alreadyOnList"></param>
        /// <param name="position"></param>
        public ResultSuccessSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArrayData(
            bool success,
            global::System.Collections.Generic.IList<string>? sharedPlatforms,
            bool? alreadyOnList,
            double? position)
        {
            this.SharedPlatforms = sharedPlatforms;
            this.AlreadyOnList = alreadyOnList;
            this.Position = position;
            this.Success = success;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArrayData" /> class.
        /// </summary>
        public ResultSuccessSuccessBooleanPosition63NumberAlreadyOnList63BooleanSharedPlatforms63StringArrayData()
        {
        }
    }
}
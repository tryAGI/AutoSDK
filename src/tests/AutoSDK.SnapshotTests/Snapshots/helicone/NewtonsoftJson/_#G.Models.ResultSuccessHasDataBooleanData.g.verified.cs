//HintName: G.Models.ResultSuccessHasDataBooleanData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResultSuccessHasDataBooleanData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hasData", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasData { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessHasDataBooleanData" /> class.
        /// </summary>
        /// <param name="hasData"></param>
        public ResultSuccessHasDataBooleanData(
            bool hasData)
        {
            this.HasData = hasData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessHasDataBooleanData" /> class.
        /// </summary>
        public ResultSuccessHasDataBooleanData()
        {
        }
    }
}
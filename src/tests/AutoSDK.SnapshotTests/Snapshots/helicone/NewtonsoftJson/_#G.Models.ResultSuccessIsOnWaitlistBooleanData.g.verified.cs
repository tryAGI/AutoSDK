//HintName: G.Models.ResultSuccessIsOnWaitlistBooleanData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResultSuccessIsOnWaitlistBooleanData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("isOnWaitlist", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsOnWaitlist { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessIsOnWaitlistBooleanData" /> class.
        /// </summary>
        /// <param name="isOnWaitlist"></param>
        public ResultSuccessIsOnWaitlistBooleanData(
            bool isOnWaitlist)
        {
            this.IsOnWaitlist = isOnWaitlist;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessIsOnWaitlistBooleanData" /> class.
        /// </summary>
        public ResultSuccessIsOnWaitlistBooleanData()
        {
        }
    }
}
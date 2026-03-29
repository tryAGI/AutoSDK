//HintName: G.Models.ResultSuccessUnsafeBooleanData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResultSuccessUnsafeBooleanData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("unsafe", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Unsafe { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessUnsafeBooleanData" /> class.
        /// </summary>
        /// <param name="unsafe"></param>
        public ResultSuccessUnsafeBooleanData(
            bool @unsafe)
        {
            this.Unsafe = @unsafe;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessUnsafeBooleanData" /> class.
        /// </summary>
        public ResultSuccessUnsafeBooleanData()
        {
        }
    }
}
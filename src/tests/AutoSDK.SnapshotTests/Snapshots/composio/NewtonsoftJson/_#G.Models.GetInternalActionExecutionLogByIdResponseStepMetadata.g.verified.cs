//HintName: G.Models.GetInternalActionExecutionLogByIdResponseStepMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetInternalActionExecutionLogByIdResponseStepMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("encryption")]
        public string? Encryption { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetInternalActionExecutionLogByIdResponseStepMetadata" /> class.
        /// </summary>
        /// <param name="encryption"></param>
        public GetInternalActionExecutionLogByIdResponseStepMetadata(
            string? encryption)
        {
            this.Encryption = encryption;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetInternalActionExecutionLogByIdResponseStepMetadata" /> class.
        /// </summary>
        public GetInternalActionExecutionLogByIdResponseStepMetadata()
        {
        }
    }
}
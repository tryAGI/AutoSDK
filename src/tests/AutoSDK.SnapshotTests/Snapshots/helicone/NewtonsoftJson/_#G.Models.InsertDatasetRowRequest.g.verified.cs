//HintName: G.Models.InsertDatasetRowRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InsertDatasetRowRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("originalColumnId")]
        public string? OriginalColumnId { get; set; }

        /// <summary>
        /// Construct a type with a set of properties K of type T
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, string> Inputs { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputRecordId", Required = global::Newtonsoft.Json.Required.Always)]
        public string InputRecordId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InsertDatasetRowRequest" /> class.
        /// </summary>
        /// <param name="inputs">
        /// Construct a type with a set of properties K of type T
        /// </param>
        /// <param name="inputRecordId"></param>
        /// <param name="originalColumnId"></param>
        public InsertDatasetRowRequest(
            global::System.Collections.Generic.Dictionary<string, string> inputs,
            string inputRecordId,
            string? originalColumnId)
        {
            this.OriginalColumnId = originalColumnId;
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
            this.InputRecordId = inputRecordId ?? throw new global::System.ArgumentNullException(nameof(inputRecordId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InsertDatasetRowRequest" /> class.
        /// </summary>
        public InsertDatasetRowRequest()
        {
        }
    }
}
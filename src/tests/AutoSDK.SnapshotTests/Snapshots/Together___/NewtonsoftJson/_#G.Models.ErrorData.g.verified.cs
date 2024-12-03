//HintName: G.Models.ErrorData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ErrorData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ErrorDataError Error { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorData" /> class.
        /// </summary>
        /// <param name="error"></param>
        public ErrorData(
            global::G.ErrorDataError error)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorData" /> class.
        /// </summary>
        public ErrorData()
        {
        }
    }
}
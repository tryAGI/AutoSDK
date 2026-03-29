//HintName: G.Models.InferenceError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InferenceError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file")]
        public string? File { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InferenceError" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="file"></param>
        public InferenceError(
            string? message,
            string? file)
        {
            this.Message = message;
            this.File = file;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InferenceError" /> class.
        /// </summary>
        public InferenceError()
        {
        }
    }
}
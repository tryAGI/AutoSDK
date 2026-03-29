//HintName: G.Models.CreateDubbingResponse3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDubbingResponse3
    {
        /// <summary>
        /// Example: Not implemented yet: Only S3 related URLs are supported at the moment
        /// </summary>
        /// <example>Not implemented yet: Only S3 related URLs are supported at the moment</example>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDubbingResponse3" /> class.
        /// </summary>
        /// <param name="error">
        /// Example: Not implemented yet: Only S3 related URLs are supported at the moment
        /// </param>
        public CreateDubbingResponse3(
            string? error)
        {
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDubbingResponse3" /> class.
        /// </summary>
        public CreateDubbingResponse3()
        {
        }
    }
}
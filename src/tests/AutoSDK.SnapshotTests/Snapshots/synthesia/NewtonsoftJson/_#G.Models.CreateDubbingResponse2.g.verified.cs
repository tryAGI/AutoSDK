//HintName: G.Models.CreateDubbingResponse2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDubbingResponse2
    {
        /// <summary>
        /// Example: One or more of the asset URLs in your video was broken
        /// </summary>
        /// <example>One or more of the asset URLs in your video was broken</example>
        [global::Newtonsoft.Json.JsonProperty("context")]
        public string? Context { get; set; }

        /// <summary>
        /// Example: BrokenAssetUrlError
        /// </summary>
        /// <example>BrokenAssetUrlError</example>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDubbingResponse2" /> class.
        /// </summary>
        /// <param name="context">
        /// Example: One or more of the asset URLs in your video was broken
        /// </param>
        /// <param name="error">
        /// Example: BrokenAssetUrlError
        /// </param>
        public CreateDubbingResponse2(
            string? context,
            string? error)
        {
            this.Context = context;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDubbingResponse2" /> class.
        /// </summary>
        public CreateDubbingResponse2()
        {
        }
    }
}
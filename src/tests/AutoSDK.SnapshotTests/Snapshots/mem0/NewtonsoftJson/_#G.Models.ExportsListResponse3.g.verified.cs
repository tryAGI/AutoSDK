//HintName: G.Models.ExportsListResponse3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExportsListResponse3
    {
        /// <summary>
        /// Example: No memory export request found
        /// </summary>
        /// <example>No memory export request found</example>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportsListResponse3" /> class.
        /// </summary>
        /// <param name="error">
        /// Example: No memory export request found
        /// </param>
        public ExportsListResponse3(
            string? error)
        {
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportsListResponse3" /> class.
        /// </summary>
        public ExportsListResponse3()
        {
        }
    }
}
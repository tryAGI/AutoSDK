//HintName: G.Models.CreateVideoStreamResponseVariant12.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVideoStreamResponseVariant12
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoStreamResponseVariant12" /> class.
        /// </summary>
        /// <param name="status"></param>
        public CreateVideoStreamResponseVariant12(
            string? status)
        {
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoStreamResponseVariant12" /> class.
        /// </summary>
        public CreateVideoStreamResponseVariant12()
        {
        }
    }
}
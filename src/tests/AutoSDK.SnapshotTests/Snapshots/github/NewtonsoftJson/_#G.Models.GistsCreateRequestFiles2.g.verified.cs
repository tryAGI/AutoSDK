//HintName: G.Models.GistsCreateRequestFiles2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GistsCreateRequestFiles2
    {
        /// <summary>
        /// Content of the file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public string Content { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GistsCreateRequestFiles2" /> class.
        /// </summary>
        /// <param name="content">
        /// Content of the file
        /// </param>
        public GistsCreateRequestFiles2(
            string content)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GistsCreateRequestFiles2" /> class.
        /// </summary>
        public GistsCreateRequestFiles2()
        {
        }
    }
}
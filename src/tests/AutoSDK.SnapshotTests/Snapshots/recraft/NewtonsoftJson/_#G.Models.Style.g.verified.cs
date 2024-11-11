//HintName: G.Models.Style.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Style
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("creation_time", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreationTime { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Style" /> class.
        /// </summary>
        /// <param name="creationTime"></param>
        /// <param name="id"></param>
        public Style(
            global::System.DateTime creationTime,
            global::System.Guid id)
        {
            this.CreationTime = creationTime;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Style" /> class.
        /// </summary>
        public Style()
        {
        }
    }
}
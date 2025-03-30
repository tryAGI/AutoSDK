//HintName: G.Models.AttachmentsOperations.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AttachmentsOperations
    {
        /// <summary>
        /// Mapping of old attachment names to new names
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rename")]
        public global::System.Collections.Generic.Dictionary<string, string>? Rename { get; set; }

        /// <summary>
        /// List of attachment names to keep
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("retain")]
        public global::System.Collections.Generic.IList<string>? Retain { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AttachmentsOperations" /> class.
        /// </summary>
        /// <param name="rename">
        /// Mapping of old attachment names to new names
        /// </param>
        /// <param name="retain">
        /// List of attachment names to keep
        /// </param>
        public AttachmentsOperations(
            global::System.Collections.Generic.Dictionary<string, string>? rename,
            global::System.Collections.Generic.IList<string>? retain)
        {
            this.Rename = rename;
            this.Retain = retain;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AttachmentsOperations" /> class.
        /// </summary>
        public AttachmentsOperations()
        {
        }
    }
}
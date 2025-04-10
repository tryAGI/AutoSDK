//HintName: G.Models.UltravoxV1MimeTypeSet.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A set of mime types. Entries may be a full mime type (e.g. "text/html") or a<br/>
    ///  type without a subtype (e.g. "text"). Entries without a subtype will match<br/>
    ///  all subtypes (e.g. "text" will match "text/html", "text/plain", etc.).
    /// </summary>
    public sealed partial class UltravoxV1MimeTypeSet
    {
        /// <summary>
        /// The mime types in this set.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mimeTypes")]
        public global::System.Collections.Generic.IList<string>? MimeTypes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1MimeTypeSet" /> class.
        /// </summary>
        /// <param name="mimeTypes">
        /// The mime types in this set.
        /// </param>
        public UltravoxV1MimeTypeSet(
            global::System.Collections.Generic.IList<string>? mimeTypes)
        {
            this.MimeTypes = mimeTypes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1MimeTypeSet" /> class.
        /// </summary>
        public UltravoxV1MimeTypeSet()
        {
        }
    }
}
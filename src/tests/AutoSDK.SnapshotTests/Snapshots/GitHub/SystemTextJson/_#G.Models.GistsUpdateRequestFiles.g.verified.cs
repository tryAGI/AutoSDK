//HintName: G.Models.GistsUpdateRequestFiles.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The gist files to be updated, renamed, or deleted. Each `key` must match the current filename<br/>
    /// (including extension) of the targeted gist file. For example: `hello.py`.<br/>
    /// To delete a file, set the whole file to null. For example: `hello.py : null`. The file will also be<br/>
    /// deleted if the specified object does not contain at least one of `content` or `filename`.
    /// </summary>
    public sealed partial class GistsUpdateRequestFiles
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GistsUpdateRequestFiles" /> class.
        /// </summary>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GistsUpdateRequestFiles(
 )
        {
        }
    }
}
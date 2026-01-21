//HintName: G.Models.GistsUpdateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GistsUpdateRequest
    {
        /// <summary>
        /// The description of the gist.<br/>
        /// Example: Example Ruby script
        /// </summary>
        /// <example>Example Ruby script</example>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The gist files to be updated, renamed, or deleted. Each `key` must match the current filename<br/>
        /// (including extension) of the targeted gist file. For example: `hello.py`.<br/>
        /// To delete a file, set the whole file to null. For example: `hello.py : null`. The file will also be<br/>
        /// deleted if the specified object does not contain at least one of `content` or `filename`.<br/>
        /// Example: {"hello.rb":{"content":"blah","filename":"goodbye.rb"}}
        /// </summary>
        /// <example>{"hello.rb":{"content":"blah","filename":"goodbye.rb"}}</example>
        [global::Newtonsoft.Json.JsonProperty("files")]
        public global::System.Collections.Generic.Dictionary<string, global::G.GistsUpdateRequestFiles2?>? Files { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GistsUpdateRequest" /> class.
        /// </summary>
        /// <param name="description">
        /// The description of the gist.<br/>
        /// Example: Example Ruby script
        /// </param>
        /// <param name="files">
        /// The gist files to be updated, renamed, or deleted. Each `key` must match the current filename<br/>
        /// (including extension) of the targeted gist file. For example: `hello.py`.<br/>
        /// To delete a file, set the whole file to null. For example: `hello.py : null`. The file will also be<br/>
        /// deleted if the specified object does not contain at least one of `content` or `filename`.<br/>
        /// Example: {"hello.rb":{"content":"blah","filename":"goodbye.rb"}}
        /// </param>
        public GistsUpdateRequest(
            string? description,
            global::System.Collections.Generic.Dictionary<string, global::G.GistsUpdateRequestFiles2?>? files)
        {
            this.Description = description;
            this.Files = files;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GistsUpdateRequest" /> class.
        /// </summary>
        public GistsUpdateRequest()
        {
        }
    }
}
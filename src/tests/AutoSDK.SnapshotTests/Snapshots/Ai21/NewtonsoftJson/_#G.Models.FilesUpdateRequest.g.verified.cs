//HintName: G.Models.FilesUpdateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FilesUpdateRequest
    {
        /// <summary>
        /// The public URL of the file, if any. This URL is not validated by<br/>
        /// AI21 or used in any way. It is strictly a piece of metadata that you can<br/>
        /// optionally attach to a file.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("publicUrl")]
        public string? PublicUrl { get; set; }

        /// <summary>
        /// Any labels to associate with this file. Separate multiple labels with commas. If<br/>
        /// provided, will overwrite all existing labels.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("labels")]
        public global::System.Collections.Generic.IList<string>? Labels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FilesUpdateRequest" /> class.
        /// </summary>
        /// <param name="publicUrl">
        /// The public URL of the file, if any. This URL is not validated by<br/>
        /// AI21 or used in any way. It is strictly a piece of metadata that you can<br/>
        /// optionally attach to a file.
        /// </param>
        /// <param name="labels">
        /// Any labels to associate with this file. Separate multiple labels with commas. If<br/>
        /// provided, will overwrite all existing labels.
        /// </param>
        public FilesUpdateRequest(
            string? publicUrl,
            global::System.Collections.Generic.IList<string>? labels)
        {
            this.PublicUrl = publicUrl;
            this.Labels = labels;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilesUpdateRequest" /> class.
        /// </summary>
        public FilesUpdateRequest()
        {
        }
    }
}
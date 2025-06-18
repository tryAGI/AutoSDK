//HintName: G.Models.ContainerFileCitationBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A citation for a container file used to generate a model response.
    /// </summary>
    public sealed partial class ContainerFileCitationBody
    {
        /// <summary>
        /// The type of the container file citation. Always `container_file_citation`.<br/>
        /// Default Value: container_file_citation
        /// </summary>
        /// <default>global::G.ContainerFileCitationBodyType.ContainerFileCitation</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ContainerFileCitationBodyType Type { get; set; } = global::G.ContainerFileCitationBodyType.ContainerFileCitation;

        /// <summary>
        /// The ID of the container file.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("container_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ContainerId { get; set; } = default!;

        /// <summary>
        /// The ID of the file.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string FileId { get; set; } = default!;

        /// <summary>
        /// The index of the first character of the container file citation in the message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int StartIndex { get; set; } = default!;

        /// <summary>
        /// The index of the last character of the container file citation in the message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int EndIndex { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerFileCitationBody" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the container file citation. Always `container_file_citation`.<br/>
        /// Default Value: container_file_citation
        /// </param>
        /// <param name="containerId">
        /// The ID of the container file.
        /// </param>
        /// <param name="fileId">
        /// The ID of the file.
        /// </param>
        /// <param name="startIndex">
        /// The index of the first character of the container file citation in the message.
        /// </param>
        /// <param name="endIndex">
        /// The index of the last character of the container file citation in the message.
        /// </param>
        public ContainerFileCitationBody(
            string containerId,
            string fileId,
            int startIndex,
            int endIndex,
            global::G.ContainerFileCitationBodyType type = global::G.ContainerFileCitationBodyType.ContainerFileCitation)
        {
            this.ContainerId = containerId ?? throw new global::System.ArgumentNullException(nameof(containerId));
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
            this.StartIndex = startIndex;
            this.EndIndex = endIndex;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerFileCitationBody" /> class.
        /// </summary>
        public ContainerFileCitationBody()
        {
        }
    }
}
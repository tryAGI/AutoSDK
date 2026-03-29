//HintName: G.Models.DatasetRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request to create or update a Dataset.
    /// </summary>
    public sealed partial class DatasetRequest
    {
        /// <summary>
        /// Path of the Dataset.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("path")]
        public string? Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("datapoints")]
        public global::System.Collections.Generic.IList<global::G.DatapointResponse>? Datapoints { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("attributes")]
        public object? Attributes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("versionName")]
        public string? VersionName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("versionDescription")]
        public string? VersionDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("readme")]
        public string? Readme { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetRequest" /> class.
        /// </summary>
        /// <param name="path">
        /// Path of the Dataset.
        /// </param>
        /// <param name="id"></param>
        /// <param name="description"></param>
        /// <param name="datapoints"></param>
        /// <param name="attributes"></param>
        /// <param name="versionName"></param>
        /// <param name="versionDescription"></param>
        /// <param name="tags"></param>
        /// <param name="readme"></param>
        public DatasetRequest(
            string? path,
            string? id,
            string? description,
            global::System.Collections.Generic.IList<global::G.DatapointResponse>? datapoints,
            object? attributes,
            string? versionName,
            string? versionDescription,
            global::System.Collections.Generic.IList<string>? tags,
            string? readme)
        {
            this.Path = path;
            this.Id = id;
            this.Description = description;
            this.Datapoints = datapoints;
            this.Attributes = attributes;
            this.VersionName = versionName;
            this.VersionDescription = versionDescription;
            this.Tags = tags;
            this.Readme = readme;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetRequest" /> class.
        /// </summary>
        public DatasetRequest()
        {
        }
    }
}
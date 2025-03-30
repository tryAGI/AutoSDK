//HintName: G.Models.DatasetTransformation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetTransformation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("path", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Path { get; set; } = default!;

        /// <summary>
        /// Enum for dataset data types.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transformation_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.DatasetTransformationType TransformationType { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetTransformation" /> class.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="transformationType">
        /// Enum for dataset data types.
        /// </param>
        public DatasetTransformation(
            global::System.Collections.Generic.IList<string> path,
            global::G.DatasetTransformationType transformationType)
        {
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.TransformationType = transformationType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetTransformation" /> class.
        /// </summary>
        public DatasetTransformation()
        {
        }
    }
}
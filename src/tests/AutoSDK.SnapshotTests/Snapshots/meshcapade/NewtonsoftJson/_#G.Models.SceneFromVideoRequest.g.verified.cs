//HintName: G.Models.SceneFromVideoRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SceneFromVideoRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lockFeet")]
        public bool? LockFeet { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maxPersonCount")]
        public int? MaxPersonCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modelVersion")]
        public string? ModelVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sceneName")]
        public string? SceneName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SceneFromVideoRequest" /> class.
        /// </summary>
        /// <param name="lockFeet"></param>
        /// <param name="maxPersonCount"></param>
        /// <param name="modelVersion"></param>
        /// <param name="sceneName"></param>
        public SceneFromVideoRequest(
            bool? lockFeet,
            int? maxPersonCount,
            string? modelVersion,
            string? sceneName)
        {
            this.LockFeet = lockFeet;
            this.MaxPersonCount = maxPersonCount;
            this.ModelVersion = modelVersion;
            this.SceneName = sceneName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SceneFromVideoRequest" /> class.
        /// </summary>
        public SceneFromVideoRequest()
        {
        }
    }
}
//HintName: G.Models.MotionBlendRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MotionBlendRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avatarName")]
        public string? AvatarName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gender")]
        public string? Gender { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("motions")]
        public global::System.Collections.Generic.IList<global::G.MotionBlendMotion>? Motions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("shapeParameters")]
        public global::System.Collections.Generic.IList<double>? ShapeParameters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sourceAvatarID")]
        public string? SourceAvatarID { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MotionBlendRequest" /> class.
        /// </summary>
        /// <param name="avatarName"></param>
        /// <param name="gender"></param>
        /// <param name="motions"></param>
        /// <param name="shapeParameters"></param>
        /// <param name="sourceAvatarID"></param>
        public MotionBlendRequest(
            string? avatarName,
            string? gender,
            global::System.Collections.Generic.IList<global::G.MotionBlendMotion>? motions,
            global::System.Collections.Generic.IList<double>? shapeParameters,
            string? sourceAvatarID)
        {
            this.AvatarName = avatarName;
            this.Gender = gender;
            this.Motions = motions;
            this.ShapeParameters = shapeParameters;
            this.SourceAvatarID = sourceAvatarID;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MotionBlendRequest" /> class.
        /// </summary>
        public MotionBlendRequest()
        {
        }
    }
}
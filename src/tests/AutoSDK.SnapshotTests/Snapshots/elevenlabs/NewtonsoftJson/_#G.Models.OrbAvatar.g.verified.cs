//HintName: G.Models.OrbAvatar.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrbAvatar
    {
        /// <summary>
        /// The type of the avatar<br/>
        /// Default Value: orb
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.OrbAvatarType? Type { get; set; }

        /// <summary>
        /// The first color of the avatar<br/>
        /// Default Value: #2792dc
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("color_1")]
        public string? Color1 { get; set; }

        /// <summary>
        /// The second color of the avatar<br/>
        /// Default Value: #9ce6e6
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("color_2")]
        public string? Color2 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrbAvatar" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the avatar<br/>
        /// Default Value: orb
        /// </param>
        /// <param name="color1">
        /// The first color of the avatar<br/>
        /// Default Value: #2792dc
        /// </param>
        /// <param name="color2">
        /// The second color of the avatar<br/>
        /// Default Value: #9ce6e6
        /// </param>
        public OrbAvatar(
            global::G.OrbAvatarType? type,
            string? color1,
            string? color2)
        {
            this.Type = type;
            this.Color1 = color1;
            this.Color2 = color2;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrbAvatar" /> class.
        /// </summary>
        public OrbAvatar()
        {
        }
    }
}
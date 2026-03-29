//HintName: G.Models.CameraControl.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CameraControl
    {
        /// <summary>
        /// Camera control type.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.CameraControlType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config")]
        public global::G.CameraControlConfig? Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CameraControl" /> class.
        /// </summary>
        /// <param name="type">
        /// Camera control type.
        /// </param>
        /// <param name="config"></param>
        public CameraControl(
            global::G.CameraControlType? type,
            global::G.CameraControlConfig? config)
        {
            this.Type = type;
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CameraControl" /> class.
        /// </summary>
        public CameraControl()
        {
        }
    }
}
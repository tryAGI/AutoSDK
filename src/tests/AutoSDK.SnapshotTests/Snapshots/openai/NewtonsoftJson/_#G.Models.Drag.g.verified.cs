//HintName: G.Models.Drag.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A drag action.
    /// </summary>
    public sealed partial class Drag
    {
        /// <summary>
        /// An array of coordinates representing the path of the drag action. Coordinates will appear as an array<br/>
        /// of objects, eg<br/>
        /// ```<br/>
        /// [<br/>
        ///   { x: 100, y: 200 },<br/>
        ///   { x: 200, y: 300 }<br/>
        /// ]<br/>
        /// ```
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("path", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Coordinate> Path { get; set; } = default!;

        /// <summary>
        /// Specifies the event type. For a drag action, this property is <br/>
        /// always set to `drag`.<br/>
        /// Default Value: drag
        /// </summary>
        /// <default>global::G.DragType.Drag</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.DragType Type { get; set; } = global::G.DragType.Drag;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Drag" /> class.
        /// </summary>
        /// <param name="path">
        /// An array of coordinates representing the path of the drag action. Coordinates will appear as an array<br/>
        /// of objects, eg<br/>
        /// ```<br/>
        /// [<br/>
        ///   { x: 100, y: 200 },<br/>
        ///   { x: 200, y: 300 }<br/>
        /// ]<br/>
        /// ```
        /// </param>
        /// <param name="type">
        /// Specifies the event type. For a drag action, this property is <br/>
        /// always set to `drag`.<br/>
        /// Default Value: drag
        /// </param>
        public Drag(
            global::System.Collections.Generic.IList<global::G.Coordinate> path,
            global::G.DragType type = global::G.DragType.Drag)
        {
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Drag" /> class.
        /// </summary>
        public Drag()
        {
        }
    }
}
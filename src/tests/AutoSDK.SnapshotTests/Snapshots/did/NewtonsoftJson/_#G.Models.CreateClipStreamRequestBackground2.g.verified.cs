//HintName: G.Models.CreateClipStreamRequestBackground2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class CreateClipStreamRequestBackground2
    {
        /// <summary>
        /// Background color of the animated result, or false to use transparent background in-case of webm result format.<br/>
        /// Example: #47ffff
        /// </summary>
        /// <example>#47ffff</example>
        [global::Newtonsoft.Json.JsonProperty("color")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.AnyOf<string, bool?>? Color { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClipStreamRequestBackground2" /> class.
        /// </summary>
        /// <param name="color">
        /// Background color of the animated result, or false to use transparent background in-case of webm result format.<br/>
        /// Example: #47ffff
        /// </param>
        public CreateClipStreamRequestBackground2(
            global::G.AnyOf<string, bool?>? color)
        {
            this.Color = color;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClipStreamRequestBackground2" /> class.
        /// </summary>
        public CreateClipStreamRequestBackground2()
        {
        }
    }
}
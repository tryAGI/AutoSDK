//HintName: G.Models.GetAvatarsResponseAvatarFaceRect.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The face rect of the avatar
    /// </summary>
    public sealed partial class GetAvatarsResponseAvatarFaceRect
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Top { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("left")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Left { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bottom")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Bottom { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("right")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Right { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAvatarsResponseAvatarFaceRect" /> class.
        /// </summary>
        /// <param name="top"></param>
        /// <param name="left"></param>
        /// <param name="bottom"></param>
        /// <param name="right"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAvatarsResponseAvatarFaceRect(
            double top,
            double left,
            double bottom,
            double right)
        {
            this.Top = top;
            this.Left = left;
            this.Bottom = bottom;
            this.Right = right;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAvatarsResponseAvatarFaceRect" /> class.
        /// </summary>
        public GetAvatarsResponseAvatarFaceRect()
        {
        }
    }
}
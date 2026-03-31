//HintName: G.Models.GetAvatarsResponseDtoAvatarFaceRect.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The face rect of the avatar
    /// </summary>
    public sealed partial class GetAvatarsResponseDtoAvatarFaceRect
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
        /// Initializes a new instance of the <see cref="GetAvatarsResponseDtoAvatarFaceRect" /> class.
        /// </summary>
        /// <param name="top"></param>
        /// <param name="left"></param>
        /// <param name="bottom"></param>
        /// <param name="right"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAvatarsResponseDtoAvatarFaceRect(
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
        /// Initializes a new instance of the <see cref="GetAvatarsResponseDtoAvatarFaceRect" /> class.
        /// </summary>
        public GetAvatarsResponseDtoAvatarFaceRect()
        {
        }
    }
}
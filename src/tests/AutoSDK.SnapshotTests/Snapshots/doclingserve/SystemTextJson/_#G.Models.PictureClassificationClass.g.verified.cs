//HintName: G.Models.PictureClassificationClass.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// PictureClassificationData.
    /// </summary>
    public sealed partial class PictureClassificationClass
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("class_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClassName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Confidence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PictureClassificationClass" /> class.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="confidence"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PictureClassificationClass(
            string className,
            double confidence)
        {
            this.ClassName = className ?? throw new global::System.ArgumentNullException(nameof(className));
            this.Confidence = confidence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PictureClassificationClass" /> class.
        /// </summary>
        public PictureClassificationClass()
        {
        }
    }
}
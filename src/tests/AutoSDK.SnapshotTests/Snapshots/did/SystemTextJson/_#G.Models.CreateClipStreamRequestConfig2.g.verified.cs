//HintName: G.Models.CreateClipStreamRequestConfig2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Advanced configuration options.
    /// </summary>
    public sealed partial class CreateClipStreamRequestConfig2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logo")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.CreateClipStreamRequestConfigLogo2, bool?>))]
        public global::G.AnyOf<global::G.CreateClipStreamRequestConfigLogo2, bool?>? Logo { get; set; }

        /// <summary>
        /// File format of the animated result<br/>
        /// Default Value: mp4
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateClipStreamRequestConfigResultFormat2JsonConverter))]
        public global::G.CreateClipStreamRequestConfigResultFormat2? ResultFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClipStreamRequestConfig2" /> class.
        /// </summary>
        /// <param name="logo"></param>
        /// <param name="resultFormat">
        /// File format of the animated result<br/>
        /// Default Value: mp4
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateClipStreamRequestConfig2(
            global::G.AnyOf<global::G.CreateClipStreamRequestConfigLogo2, bool?>? logo,
            global::G.CreateClipStreamRequestConfigResultFormat2? resultFormat)
        {
            this.Logo = logo;
            this.ResultFormat = resultFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClipStreamRequestConfig2" /> class.
        /// </summary>
        public CreateClipStreamRequestConfig2()
        {
        }
    }
}
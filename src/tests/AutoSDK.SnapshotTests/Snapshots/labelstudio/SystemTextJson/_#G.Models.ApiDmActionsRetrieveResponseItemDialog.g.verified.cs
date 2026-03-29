//HintName: G.Models.ApiDmActionsRetrieveResponseItemDialog.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiDmActionsRetrieveResponseItemDialog
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("form")]
        public global::System.Collections.Generic.IList<object>? Form { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiDmActionsRetrieveResponseItemDialog" /> class.
        /// </summary>
        /// <param name="form"></param>
        /// <param name="text"></param>
        /// <param name="title"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiDmActionsRetrieveResponseItemDialog(
            global::System.Collections.Generic.IList<object>? form,
            string? text,
            string? title,
            string? type)
        {
            this.Form = form;
            this.Text = text;
            this.Title = title;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiDmActionsRetrieveResponseItemDialog" /> class.
        /// </summary>
        public ApiDmActionsRetrieveResponseItemDialog()
        {
        }
    }
}
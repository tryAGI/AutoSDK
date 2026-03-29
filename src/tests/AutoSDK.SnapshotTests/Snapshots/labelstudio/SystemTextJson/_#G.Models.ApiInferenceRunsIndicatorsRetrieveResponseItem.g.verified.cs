//HintName: G.Models.ApiInferenceRunsIndicatorsRetrieveResponseItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiInferenceRunsIndicatorsRetrieveResponseItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        public object? Values { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiInferenceRunsIndicatorsRetrieveResponseItem" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="values"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiInferenceRunsIndicatorsRetrieveResponseItem(
            string? title,
            object? values)
        {
            this.Title = title;
            this.Values = values;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiInferenceRunsIndicatorsRetrieveResponseItem" /> class.
        /// </summary>
        public ApiInferenceRunsIndicatorsRetrieveResponseItem()
        {
        }
    }
}
//HintName: G.Models.LSEKeyIndicatorValue.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Key indicator value for Label Studio Enterprise.<br/>
    /// Attributes:<br/>
    ///     title: The title for this metric, to be displayed to the user<br/>
    ///     values: Dictionary of key-value pairs for the indicator values
    /// </summary>
    public sealed partial class LSEKeyIndicatorValue
    {
        /// <summary>
        /// The title for this metric, to be displayed to the user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// Dictionary of key-value pairs for the indicator values
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Values { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LSEKeyIndicatorValue" /> class.
        /// </summary>
        /// <param name="title">
        /// The title for this metric, to be displayed to the user
        /// </param>
        /// <param name="values">
        /// Dictionary of key-value pairs for the indicator values
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LSEKeyIndicatorValue(
            string title,
            object values)
        {
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Values = values ?? throw new global::System.ArgumentNullException(nameof(values));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LSEKeyIndicatorValue" /> class.
        /// </summary>
        public LSEKeyIndicatorValue()
        {
        }
    }
}
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
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// Dictionary of key-value pairs for the indicator values
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("values", Required = global::Newtonsoft.Json.Required.Always)]
        public object Values { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
//HintName: G.Models.MergeField.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A merge field consists of a key; `find`, and a value; `replace`. Merge fields can be used to replace placeholders within the JSON edit to create re-usable templates. Placeholders should be a string with double brace delimiters, i.e. `"{{NAME}}"`. A placeholder can be used for any value within the JSON edit.
    /// </summary>
    public sealed partial class MergeField
    {
        /// <summary>
        /// The string to find &lt;u&gt;without&lt;/u&gt; delimiters.<br/>
        /// Example: NAME
        /// </summary>
        /// <example>NAME</example>
        [global::Newtonsoft.Json.JsonProperty("find", Required = global::Newtonsoft.Json.Required.Always)]
        public string Find { get; set; } = default!;

        /// <summary>
        /// The replacement value. The replacement can be any valid JSON type - string, boolean, number, etc...<br/>
        /// Example: Jane
        /// </summary>
        /// <example>Jane</example>
        [global::Newtonsoft.Json.JsonProperty("replace", Required = global::Newtonsoft.Json.Required.Always)]
        public object Replace { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MergeField" /> class.
        /// </summary>
        /// <param name="find">
        /// The string to find &lt;u&gt;without&lt;/u&gt; delimiters.<br/>
        /// Example: NAME
        /// </param>
        /// <param name="replace">
        /// The replacement value. The replacement can be any valid JSON type - string, boolean, number, etc...<br/>
        /// Example: Jane
        /// </param>
        public MergeField(
            string find,
            object replace)
        {
            this.Find = find ?? throw new global::System.ArgumentNullException(nameof(find));
            this.Replace = replace ?? throw new global::System.ArgumentNullException(nameof(replace));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MergeField" /> class.
        /// </summary>
        public MergeField()
        {
        }
    }
}
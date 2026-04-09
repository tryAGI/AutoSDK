//HintName: G.Models.PostToolsExecuteByToolSlugRequestCustomAuthParamsParameter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostToolsExecuteByToolSlugRequestCustomAuthParamsParameter
    {
        /// <summary>
        /// The name of the parameter. For example, 'x-api-key', 'Content-Type', etc.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The location of the parameter. Can be 'query' or 'header'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("in", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PostToolsExecuteByToolSlugRequestCustomAuthParamsParameterInJsonConverter))]
        public global::G.PostToolsExecuteByToolSlugRequestCustomAuthParamsParameterIn In { get; set; } = default!;

        /// <summary>
        /// The value of the parameter. For example, '1234567890', 'application/json', etc.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<string, double?> Value { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolsExecuteByToolSlugRequestCustomAuthParamsParameter" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the parameter. For example, 'x-api-key', 'Content-Type', etc.
        /// </param>
        /// <param name="in">
        /// The location of the parameter. Can be 'query' or 'header'.
        /// </param>
        /// <param name="value">
        /// The value of the parameter. For example, '1234567890', 'application/json', etc.
        /// </param>
        public PostToolsExecuteByToolSlugRequestCustomAuthParamsParameter(
            string name,
            global::G.PostToolsExecuteByToolSlugRequestCustomAuthParamsParameterIn @in,
            global::G.AnyOf<string, double?> value)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.In = @in;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolsExecuteByToolSlugRequestCustomAuthParamsParameter" /> class.
        /// </summary>
        public PostToolsExecuteByToolSlugRequestCustomAuthParamsParameter()
        {
        }
    }
}
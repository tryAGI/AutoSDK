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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The location of the parameter. Can be 'query' or 'header'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("in")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PostToolsExecuteByToolSlugRequestCustomAuthParamsParameterInJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PostToolsExecuteByToolSlugRequestCustomAuthParamsParameterIn In { get; set; }

        /// <summary>
        /// The value of the parameter. For example, '1234567890', 'application/json', etc.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<string, double?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<string, double?> Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
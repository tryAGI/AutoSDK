//HintName: G.Models.OpenAPIParameter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAPIParameter
    {
        /// <summary>
        /// 是否所有的都可以用这个
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("default_value")]
        public string? DefaultValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("items")]
        public global::G.OpenAPIParameter? Items { get; set; }

        /// <summary>
        /// Object类型下的子类型
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("properties")]
        public global::System.Collections.Generic.Dictionary<string, global::G.OpenAPIParameter>? Properties { get; set; }

        /// <summary>
        /// 是否必填
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required")]
        public bool? Required { get; set; }

        /// <summary>
        /// 参数类型，来源于OpenAPIParamType
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.OpenAPIParameterType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPIParameter" /> class.
        /// </summary>
        /// <param name="defaultValue">
        /// 是否所有的都可以用这个
        /// </param>
        /// <param name="description"></param>
        /// <param name="items"></param>
        /// <param name="properties">
        /// Object类型下的子类型
        /// </param>
        /// <param name="required">
        /// 是否必填
        /// </param>
        /// <param name="type">
        /// 参数类型，来源于OpenAPIParamType
        /// </param>
        public OpenAPIParameter(
            string? defaultValue,
            string? description,
            global::G.OpenAPIParameter? items,
            global::System.Collections.Generic.Dictionary<string, global::G.OpenAPIParameter>? properties,
            bool? required,
            global::G.OpenAPIParameterType? type)
        {
            this.DefaultValue = defaultValue;
            this.Description = description;
            this.Items = items;
            this.Properties = properties;
            this.Required = required;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPIParameter" /> class.
        /// </summary>
        public OpenAPIParameter()
        {
        }
    }
}
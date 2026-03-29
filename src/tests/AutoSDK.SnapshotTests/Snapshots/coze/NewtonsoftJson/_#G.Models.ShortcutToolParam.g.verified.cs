//HintName: G.Models.ShortcutToolParam.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ShortcutToolParam
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("default_value")]
        public string? DefaultValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 是否是panel参数
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_refer_component")]
        public bool? IsReferComponent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_required")]
        public bool? IsRequired { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShortcutToolParam" /> class.
        /// </summary>
        /// <param name="defaultValue"></param>
        /// <param name="description"></param>
        /// <param name="isReferComponent">
        /// 是否是panel参数
        /// </param>
        /// <param name="isRequired"></param>
        /// <param name="name"></param>
        /// <param name="type"></param>
        public ShortcutToolParam(
            string? defaultValue,
            string? description,
            bool? isReferComponent,
            bool? isRequired,
            string? name,
            string? type)
        {
            this.DefaultValue = defaultValue;
            this.Description = description;
            this.IsReferComponent = isReferComponent;
            this.IsRequired = isRequired;
            this.Name = name;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShortcutToolParam" /> class.
        /// </summary>
        public ShortcutToolParam()
        {
        }
    }
}
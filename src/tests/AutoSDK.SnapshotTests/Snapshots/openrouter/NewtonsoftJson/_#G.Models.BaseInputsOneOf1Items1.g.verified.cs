//HintName: G.Models.BaseInputsOneOf1Items1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BaseInputsOneOf1Items1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.BaseInputsOneOf1ItemsOneOf1Type? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.BaseInputsOneOf1ItemsOneOf1Role Role { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.BaseInputsOneOf1ItemsOneOf1ContentItems> Content { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseInputsOneOf1Items1" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="role"></param>
        /// <param name="content"></param>
        /// <param name="type"></param>
        public BaseInputsOneOf1Items1(
            string id,
            global::G.BaseInputsOneOf1ItemsOneOf1Role role,
            global::System.Collections.Generic.IList<global::G.BaseInputsOneOf1ItemsOneOf1ContentItems> content,
            global::G.BaseInputsOneOf1ItemsOneOf1Type? type)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
            this.Role = role;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseInputsOneOf1Items1" /> class.
        /// </summary>
        public BaseInputsOneOf1Items1()
        {
        }
    }
}
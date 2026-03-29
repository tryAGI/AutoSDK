//HintName: G.Models.BaseInputsOneOf1Items0.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BaseInputsOneOf1Items0
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.BaseInputsOneOf1ItemsOneOf0Type? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.BaseInputsOneOf1ItemsOneOf0Role Role { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.BaseInputsOneOf1ItemsOneOf0Content Content { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("phase")]
        public global::G.BaseInputsOneOf1ItemsOneOf0Phase? Phase { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseInputsOneOf1Items0" /> class.
        /// </summary>
        /// <param name="role"></param>
        /// <param name="content"></param>
        /// <param name="type"></param>
        /// <param name="phase"></param>
        public BaseInputsOneOf1Items0(
            global::G.BaseInputsOneOf1ItemsOneOf0Role role,
            global::G.BaseInputsOneOf1ItemsOneOf0Content content,
            global::G.BaseInputsOneOf1ItemsOneOf0Type? type,
            global::G.BaseInputsOneOf1ItemsOneOf0Phase? phase)
        {
            this.Type = type;
            this.Role = role;
            this.Content = content;
            this.Phase = phase;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseInputsOneOf1Items0" /> class.
        /// </summary>
        public BaseInputsOneOf1Items0()
        {
        }
    }
}
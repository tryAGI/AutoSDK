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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BaseInputsOneOf1ItemsOneOf1TypeJsonConverter))]
        public global::G.BaseInputsOneOf1ItemsOneOf1Type? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BaseInputsOneOf1ItemsOneOf1RoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.BaseInputsOneOf1ItemsOneOf1Role Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.BaseInputsOneOf1ItemsOneOf1ContentItems> Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseInputsOneOf1Items1" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="role"></param>
        /// <param name="content"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
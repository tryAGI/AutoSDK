//HintName: G.Models.UserFormRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserFormRequest
    {
        /// <summary>
        /// A JSON object containing form data with string values<br/>
        /// Example: {"favorite_color":"blue","preferred_contact":"email"}
        /// </summary>
        /// <example>{"favorite_color":"blue","preferred_contact":"email"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("form")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Form { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserFormRequest" /> class.
        /// </summary>
        /// <param name="form">
        /// A JSON object containing form data with string values<br/>
        /// Example: {"favorite_color":"blue","preferred_contact":"email"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserFormRequest(
            global::System.Collections.Generic.Dictionary<string, string> form)
        {
            this.Form = form ?? throw new global::System.ArgumentNullException(nameof(form));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserFormRequest" /> class.
        /// </summary>
        public UserFormRequest()
        {
        }
    }
}
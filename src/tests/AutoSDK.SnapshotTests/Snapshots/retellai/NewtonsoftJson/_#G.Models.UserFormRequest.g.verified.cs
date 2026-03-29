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
        [global::Newtonsoft.Json.JsonProperty("form", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, string> Form { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserFormRequest" /> class.
        /// </summary>
        /// <param name="form">
        /// A JSON object containing form data with string values<br/>
        /// Example: {"favorite_color":"blue","preferred_contact":"email"}
        /// </param>
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
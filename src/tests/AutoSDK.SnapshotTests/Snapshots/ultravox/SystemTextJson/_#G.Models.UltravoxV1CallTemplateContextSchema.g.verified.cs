//HintName: G.Models.UltravoxV1CallTemplateContextSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// JSON schema for the variables used in string templates. If unset, a default schema will<br/>
    ///  be created from the variables used in the string templates.<br/>
    ///  Call creation requests must provide context adhering to this schema.<br/>
    ///  The follow fields are treated as templates:<br/>
    ///    * system_prompt<br/>
    ///    * language_hint<br/>
    ///    * time_exceeded_message<br/>
    ///    * inactivity_messages.message<br/>
    ///    * selected_tools.description<br/>
    ///    * selected_tools.static_parameters.value<br/>
    ///    * selected_tools.http.auth_headers.value<br/>
    ///    * selected_tools.http.auth_query_params.value<br/>
    ///  If multiple stages are defined for the call, each must define its own context schema (or use the generated one).
    /// </summary>
    public sealed partial class UltravoxV1CallTemplateContextSchema
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
//HintName: G.Models.AssistantOverridesVariableValues.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// These are values that will be used to replace the template variables in the assistant messages and other text-based fields.<br/>
    /// This uses LiquidJS syntax. https://liquidjs.com/tutorials/intro-to-liquid.html<br/>
    /// So for example, `{{ name }}` will be replaced with the value of `name` in `variableValues`.<br/>
    /// `{{"now" | date: "%b %d, %Y, %I:%M %p", "America/New_York"}}` will be replaced with the current date and time in New York.<br/>
    ///  Some VAPI reserved defaults:<br/>
    ///  - *customer* - the customer object
    /// </summary>
    public sealed partial class AssistantOverridesVariableValues
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
//HintName: G.Models.WorkflowOverrides.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowOverrides
    {
        /// <summary>
        /// These are values that will be used to replace the template variables in the workflow messages and other text-based fields.<br/>
        /// This uses LiquidJS syntax. https://liquidjs.com/tutorials/intro-to-liquid.html<br/>
        /// So for example, `{{ name }}` will be replaced with the value of `name` in `variableValues`.<br/>
        /// `{{"now" | date: "%b %d, %Y, %I:%M %p", "America/New_York"}}` will be replaced with the current date and time in New York.<br/>
        ///  Some VAPI reserved defaults:<br/>
        ///  - *customer* - the customer object
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("variableValues")]
        public object? VariableValues { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowOverrides" /> class.
        /// </summary>
        /// <param name="variableValues">
        /// These are values that will be used to replace the template variables in the workflow messages and other text-based fields.<br/>
        /// This uses LiquidJS syntax. https://liquidjs.com/tutorials/intro-to-liquid.html<br/>
        /// So for example, `{{ name }}` will be replaced with the value of `name` in `variableValues`.<br/>
        /// `{{"now" | date: "%b %d, %Y, %I:%M %p", "America/New_York"}}` will be replaced with the current date and time in New York.<br/>
        ///  Some VAPI reserved defaults:<br/>
        ///  - *customer* - the customer object
        /// </param>
        public WorkflowOverrides(
            object? variableValues)
        {
            this.VariableValues = variableValues;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowOverrides" /> class.
        /// </summary>
        public WorkflowOverrides()
        {
        }
    }
}
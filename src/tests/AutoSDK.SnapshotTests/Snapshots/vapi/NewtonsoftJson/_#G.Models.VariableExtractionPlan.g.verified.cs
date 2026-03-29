//HintName: G.Models.VariableExtractionPlan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VariableExtractionPlan
    {
        /// <summary>
        /// This is the schema to extract.<br/>
        /// Examples:<br/>
        /// 1. To extract object properties, you can use the following schema:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "type": "object",<br/>
        ///   "properties": {<br/>
        ///     "name": {<br/>
        ///       "type": "string"<br/>
        ///     },<br/>
        ///     "age": {<br/>
        ///       "type": "number"<br/>
        ///     }<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// These will be extracted as `{{ name }}` and `{{ age }}` respectively. To emphasize, object properties are extracted as direct global variables.<br/>
        /// 2. To extract nested properties, you can use the following schema:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "type": "object",<br/>
        ///   "properties": {<br/>
        ///     "name": {<br/>
        ///       "type": "object",<br/>
        ///       "properties": {<br/>
        ///         "first": {<br/>
        ///           "type": "string"<br/>
        ///         },<br/>
        ///         "last": {<br/>
        ///           "type": "string"<br/>
        ///         }<br/>
        ///       }<br/>
        ///     }<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// These will be extracted as `{{ name }}`. And, `{{ name.first }}` and `{{ name.last }}` will be accessible.<br/>
        /// 3. To extract array items, you can use the following schema:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "type": "array",<br/>
        ///   "title": "zipCodes",<br/>
        ///   "items": {<br/>
        ///     "type": "string"<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// This will be extracted as `{{ zipCodes }}`. To access the array items, you can use `{{ zipCodes[0] }}` and `{{ zipCodes[1] }}`.<br/>
        /// 4. To extract array of objects, you can use the following schema:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "type": "array",<br/>
        ///   "name": "people",<br/>
        ///   "items": {<br/>
        ///     "type": "object",<br/>
        ///     "properties": {<br/>
        ///       "name": {<br/>
        ///         "type": "string"<br/>
        ///       },<br/>
        ///       "age": {<br/>
        ///         "type": "number"<br/>
        ///       },<br/>
        ///       "zipCodes": {<br/>
        ///         "type": "array",<br/>
        ///         "items": {<br/>
        ///           "type": "string"<br/>
        ///         }<br/>
        ///       }<br/>
        ///     }<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// This will be extracted as `{{ people }}`. To access the array items, you can use `{{ people[n].name }}`, `{{ people[n].age }}`, `{{ people[n].zipCodes }}`, `{{ people[n].zipCodes[0] }}` and `{{ people[n].zipCodes[1] }}`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("schema")]
        public global::G.JsonSchema? Schema { get; set; }

        /// <summary>
        /// These are additional variables to create.<br/>
        /// These will be accessible during the call as `{{key}}` and stored in `call.artifact.variableValues` after the call.<br/>
        /// Example:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "aliases": [<br/>
        ///     {<br/>
        ///       "key": "customerName",<br/>
        ///       "value": "{{name}}"<br/>
        ///     },<br/>
        ///     {<br/>
        ///       "key": "fullName",<br/>
        ///       "value": "{{firstName}} {{lastName}}"<br/>
        ///     },<br/>
        ///     {<br/>
        ///       "key": "greeting",<br/>
        ///       "value": "Hello {{name}}, welcome to {{company}}!"<br/>
        ///     },<br/>
        ///     {<br/>
        ///       "key": "customerCity",<br/>
        ///       "value": "{{addresses[0].city}}"<br/>
        ///     },<br/>
        ///     {<br/>
        ///       "key": "something",<br/>
        ///       "value": "{{any liquid}}"<br/>
        ///     }<br/>
        ///   ]<br/>
        /// }<br/>
        /// ```<br/>
        /// This will create variables `customerName`, `fullName`, `greeting`, `customerCity`, and `something`. To access these variables, you can reference them as `{{customerName}}`, `{{fullName}}`, `{{greeting}}`, `{{customerCity}}`, and `{{something}}`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("aliases")]
        public global::System.Collections.Generic.IList<global::G.VariableExtractionAlias>? Aliases { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VariableExtractionPlan" /> class.
        /// </summary>
        /// <param name="schema">
        /// This is the schema to extract.<br/>
        /// Examples:<br/>
        /// 1. To extract object properties, you can use the following schema:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "type": "object",<br/>
        ///   "properties": {<br/>
        ///     "name": {<br/>
        ///       "type": "string"<br/>
        ///     },<br/>
        ///     "age": {<br/>
        ///       "type": "number"<br/>
        ///     }<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// These will be extracted as `{{ name }}` and `{{ age }}` respectively. To emphasize, object properties are extracted as direct global variables.<br/>
        /// 2. To extract nested properties, you can use the following schema:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "type": "object",<br/>
        ///   "properties": {<br/>
        ///     "name": {<br/>
        ///       "type": "object",<br/>
        ///       "properties": {<br/>
        ///         "first": {<br/>
        ///           "type": "string"<br/>
        ///         },<br/>
        ///         "last": {<br/>
        ///           "type": "string"<br/>
        ///         }<br/>
        ///       }<br/>
        ///     }<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// These will be extracted as `{{ name }}`. And, `{{ name.first }}` and `{{ name.last }}` will be accessible.<br/>
        /// 3. To extract array items, you can use the following schema:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "type": "array",<br/>
        ///   "title": "zipCodes",<br/>
        ///   "items": {<br/>
        ///     "type": "string"<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// This will be extracted as `{{ zipCodes }}`. To access the array items, you can use `{{ zipCodes[0] }}` and `{{ zipCodes[1] }}`.<br/>
        /// 4. To extract array of objects, you can use the following schema:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "type": "array",<br/>
        ///   "name": "people",<br/>
        ///   "items": {<br/>
        ///     "type": "object",<br/>
        ///     "properties": {<br/>
        ///       "name": {<br/>
        ///         "type": "string"<br/>
        ///       },<br/>
        ///       "age": {<br/>
        ///         "type": "number"<br/>
        ///       },<br/>
        ///       "zipCodes": {<br/>
        ///         "type": "array",<br/>
        ///         "items": {<br/>
        ///           "type": "string"<br/>
        ///         }<br/>
        ///       }<br/>
        ///     }<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// This will be extracted as `{{ people }}`. To access the array items, you can use `{{ people[n].name }}`, `{{ people[n].age }}`, `{{ people[n].zipCodes }}`, `{{ people[n].zipCodes[0] }}` and `{{ people[n].zipCodes[1] }}`.
        /// </param>
        /// <param name="aliases">
        /// These are additional variables to create.<br/>
        /// These will be accessible during the call as `{{key}}` and stored in `call.artifact.variableValues` after the call.<br/>
        /// Example:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "aliases": [<br/>
        ///     {<br/>
        ///       "key": "customerName",<br/>
        ///       "value": "{{name}}"<br/>
        ///     },<br/>
        ///     {<br/>
        ///       "key": "fullName",<br/>
        ///       "value": "{{firstName}} {{lastName}}"<br/>
        ///     },<br/>
        ///     {<br/>
        ///       "key": "greeting",<br/>
        ///       "value": "Hello {{name}}, welcome to {{company}}!"<br/>
        ///     },<br/>
        ///     {<br/>
        ///       "key": "customerCity",<br/>
        ///       "value": "{{addresses[0].city}}"<br/>
        ///     },<br/>
        ///     {<br/>
        ///       "key": "something",<br/>
        ///       "value": "{{any liquid}}"<br/>
        ///     }<br/>
        ///   ]<br/>
        /// }<br/>
        /// ```<br/>
        /// This will create variables `customerName`, `fullName`, `greeting`, `customerCity`, and `something`. To access these variables, you can reference them as `{{customerName}}`, `{{fullName}}`, `{{greeting}}`, `{{customerCity}}`, and `{{something}}`.
        /// </param>
        public VariableExtractionPlan(
            global::G.JsonSchema? schema,
            global::System.Collections.Generic.IList<global::G.VariableExtractionAlias>? aliases)
        {
            this.Schema = schema;
            this.Aliases = aliases;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VariableExtractionPlan" /> class.
        /// </summary>
        public VariableExtractionPlan()
        {
        }
    }
}
﻿//HintName: G.Models.Tool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Tool
    {
        /// <summary>
        /// The description of what the tool does, the model uses the description to choose when and how to call the function.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// The name of the tool to be called. Valid names contain only the characters `a-z`, `A-Z`, `0-9`, `_` and must not begin with a digit.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The input parameters of the tool. Accepts a dictionary where the key is the name of the parameter and the value is the parameter spec. Valid parameter names contain only the characters `a-z`, `A-Z`, `0-9`, `_` and must not begin with a digit.<br/>
        /// ```<br/>
        /// {<br/>
        ///   "my_param": {<br/>
        ///     "description": &lt;string&gt;,<br/>
        ///     "type": &lt;string&gt;, // any python data type, such as 'str', 'bool'<br/>
        ///     "required": &lt;boolean&gt;<br/>
        ///   }<br/>
        /// }<br/>
        /// ```
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameter_definitions")]
        public global::System.Collections.Generic.Dictionary<string, global::G.ToolParameterDefinitions2>? ParameterDefinitions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Tool" /> class.
        /// </summary>
        /// <param name="description">
        /// The description of what the tool does, the model uses the description to choose when and how to call the function.
        /// </param>
        /// <param name="name">
        /// The name of the tool to be called. Valid names contain only the characters `a-z`, `A-Z`, `0-9`, `_` and must not begin with a digit.
        /// </param>
        /// <param name="parameterDefinitions">
        /// The input parameters of the tool. Accepts a dictionary where the key is the name of the parameter and the value is the parameter spec. Valid parameter names contain only the characters `a-z`, `A-Z`, `0-9`, `_` and must not begin with a digit.<br/>
        /// ```<br/>
        /// {<br/>
        ///   "my_param": {<br/>
        ///     "description": &lt;string&gt;,<br/>
        ///     "type": &lt;string&gt;, // any python data type, such as 'str', 'bool'<br/>
        ///     "required": &lt;boolean&gt;<br/>
        ///   }<br/>
        /// }<br/>
        /// ```
        /// </param>
        public Tool(
            string description,
            string name,
            global::System.Collections.Generic.Dictionary<string, global::G.ToolParameterDefinitions2>? parameterDefinitions)
        {
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ParameterDefinitions = parameterDefinitions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Tool" /> class.
        /// </summary>
        public Tool()
        {
        }
    }
}
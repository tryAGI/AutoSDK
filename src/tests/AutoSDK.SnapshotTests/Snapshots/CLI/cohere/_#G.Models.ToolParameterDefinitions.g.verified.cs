﻿//HintName: G.Models.ToolParameterDefinitions.g.cs

#nullable enable

namespace G
{
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
    public sealed partial class ToolParameterDefinitions
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
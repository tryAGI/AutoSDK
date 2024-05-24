//HintName: G.Models.License.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// License
    /// </summary>
    public sealed partial class License
    {
        /// <summary>
        /// <br/>Example: mit
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key", Required = global::Newtonsoft.Json.Required.Always)]
        public string Key { get; set; } = default!;

        /// <summary>
        /// <br/>Example: MIT License
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// <br/>Example: MIT
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("spdx_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string? SpdxId { get; set; } = default!;

        /// <summary>
        /// <br/>Example: https://api.github.com/licenses/mit
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Url { get; set; } = default!;

        /// <summary>
        /// <br/>Example: MDc6TGljZW5zZW1pdA==
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// <br/>Example: http://choosealicense.com/licenses/mit/
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// <br/>Example: A permissive license that is short and to the point. It lets people do anything with your code with proper attribution and without warranty.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// <br/>Example: Create a text file (typically named LICENSE or LICENSE.txt) in the root of your source code and copy the text of the license into the file. Replace [year] with the current year and [fullname] with the name (or names) of the copyright holders.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("implementation", Required = global::Newtonsoft.Json.Required.Always)]
        public string Implementation { get; set; } = default!;

        /// <summary>
        /// <br/>Example: [commercial-use, modifications, distribution, sublicense, private-use]
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("permissions", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Permissions { get; set; } = default!;

        /// <summary>
        /// <br/>Example: [include-copyright]
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conditions", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Conditions { get; set; } = default!;

        /// <summary>
        /// <br/>Example: [no-liability]
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limitations", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Limitations { get; set; } = default!;

        /// <summary>
        /// <br/>Example: 
        /// The MIT License (MIT)
        /// Copyright (c) [year] [fullname]
        /// Permission is hereby granted, free of charge, to any person obtaining a copy
        /// of this software and associated documentation files (the "Software"), to deal
        /// in the Software without restriction, including without limitation the rights
        /// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
        /// copies of the Software, and to permit persons to whom the Software is
        /// furnished to do so, subject to the following conditions:
        /// The above copyright notice and this permission notice shall be included in all
        /// copies or substantial portions of the Software.
        /// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
        /// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
        /// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
        /// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
        /// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
        /// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
        /// SOFTWARE.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body", Required = global::Newtonsoft.Json.Required.Always)]
        public string Body { get; set; } = default!;

        /// <summary>
        /// <br/>Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("featured", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Featured { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
﻿//HintName: G.Models.License.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// License
    /// </summary>
    public sealed partial class License
    {
        /// <summary>
        /// Example: mit
        /// </summary>
        /// <example>mit</example>
        [global::Newtonsoft.Json.JsonProperty("key", Required = global::Newtonsoft.Json.Required.Always)]
        public string Key { get; set; } = default!;

        /// <summary>
        /// Example: MIT License
        /// </summary>
        /// <example>MIT License</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Example: MIT
        /// </summary>
        /// <example>MIT</example>
        [global::Newtonsoft.Json.JsonProperty("spdx_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string? SpdxId { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/licenses/mit
        /// </summary>
        /// <example>https://api.github.com/licenses/mit</example>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Url { get; set; } = default!;

        /// <summary>
        /// Example: MDc6TGljZW5zZW1pdA==
        /// </summary>
        /// <example>MDc6TGljZW5zZW1pdA==</example>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// Example: http://choosealicense.com/licenses/mit/
        /// </summary>
        /// <example>http://choosealicense.com/licenses/mit/</example>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// Example: A permissive license that is short and to the point. It lets people do anything with your code with proper attribution and without warranty.
        /// </summary>
        /// <example>A permissive license that is short and to the point. It lets people do anything with your code with proper attribution and without warranty.</example>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// Example: Create a text file (typically named LICENSE or LICENSE.txt) in the root of your source code and copy the text of the license into the file. Replace [year] with the current year and [fullname] with the name (or names) of the copyright holders.
        /// </summary>
        /// <example>Create a text file (typically named LICENSE or LICENSE.txt) in the root of your source code and copy the text of the license into the file. Replace [year] with the current year and [fullname] with the name (or names) of the copyright holders.</example>
        [global::Newtonsoft.Json.JsonProperty("implementation", Required = global::Newtonsoft.Json.Required.Always)]
        public string Implementation { get; set; } = default!;

        /// <summary>
        /// Example: [commercial-use, modifications, distribution, sublicense, private-use]
        /// </summary>
        /// <example>[commercial-use, modifications, distribution, sublicense, private-use]</example>
        [global::Newtonsoft.Json.JsonProperty("permissions", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Permissions { get; set; } = default!;

        /// <summary>
        /// Example: [include-copyright]
        /// </summary>
        /// <example>[include-copyright]</example>
        [global::Newtonsoft.Json.JsonProperty("conditions", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Conditions { get; set; } = default!;

        /// <summary>
        /// Example: [no-liability]
        /// </summary>
        /// <example>[no-liability]</example>
        [global::Newtonsoft.Json.JsonProperty("limitations", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Limitations { get; set; } = default!;

        /// <summary>
        /// Example: <br/>
        /// The MIT License (MIT)<br/>
        /// Copyright (c) [year] [fullname]<br/>
        /// Permission is hereby granted, free of charge, to any person obtaining a copy<br/>
        /// of this software and associated documentation files (the "Software"), to deal<br/>
        /// in the Software without restriction, including without limitation the rights<br/>
        /// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell<br/>
        /// copies of the Software, and to permit persons to whom the Software is<br/>
        /// furnished to do so, subject to the following conditions:<br/>
        /// The above copyright notice and this permission notice shall be included in all<br/>
        /// copies or substantial portions of the Software.<br/>
        /// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR<br/>
        /// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,<br/>
        /// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE<br/>
        /// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER<br/>
        /// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,<br/>
        /// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE<br/>
        /// SOFTWARE.
        /// </summary>
        /// <example>
        /// The MIT License (MIT)<br/>
        /// Copyright (c) [year] [fullname]<br/>
        /// Permission is hereby granted, free of charge, to any person obtaining a copy<br/>
        /// of this software and associated documentation files (the "Software"), to deal<br/>
        /// in the Software without restriction, including without limitation the rights<br/>
        /// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell<br/>
        /// copies of the Software, and to permit persons to whom the Software is<br/>
        /// furnished to do so, subject to the following conditions:<br/>
        /// The above copyright notice and this permission notice shall be included in all<br/>
        /// copies or substantial portions of the Software.<br/>
        /// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR<br/>
        /// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,<br/>
        /// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE<br/>
        /// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER<br/>
        /// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,<br/>
        /// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE<br/>
        /// SOFTWARE.
        /// </example>
        [global::Newtonsoft.Json.JsonProperty("body", Required = global::Newtonsoft.Json.Required.Always)]
        public string Body { get; set; } = default!;

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("featured", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Featured { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="License" /> class.
        /// </summary>
        /// <param name="key">
        /// Example: mit
        /// </param>
        /// <param name="name">
        /// Example: MIT License
        /// </param>
        /// <param name="spdxId">
        /// Example: MIT
        /// </param>
        /// <param name="url">
        /// Example: https://api.github.com/licenses/mit
        /// </param>
        /// <param name="nodeId">
        /// Example: MDc6TGljZW5zZW1pdA==
        /// </param>
        /// <param name="htmlUrl">
        /// Example: http://choosealicense.com/licenses/mit/
        /// </param>
        /// <param name="description">
        /// Example: A permissive license that is short and to the point. It lets people do anything with your code with proper attribution and without warranty.
        /// </param>
        /// <param name="implementation">
        /// Example: Create a text file (typically named LICENSE or LICENSE.txt) in the root of your source code and copy the text of the license into the file. Replace [year] with the current year and [fullname] with the name (or names) of the copyright holders.
        /// </param>
        /// <param name="permissions">
        /// Example: [commercial-use, modifications, distribution, sublicense, private-use]
        /// </param>
        /// <param name="conditions">
        /// Example: [include-copyright]
        /// </param>
        /// <param name="limitations">
        /// Example: [no-liability]
        /// </param>
        /// <param name="body">
        /// Example: <br/>
        /// The MIT License (MIT)<br/>
        /// Copyright (c) [year] [fullname]<br/>
        /// Permission is hereby granted, free of charge, to any person obtaining a copy<br/>
        /// of this software and associated documentation files (the "Software"), to deal<br/>
        /// in the Software without restriction, including without limitation the rights<br/>
        /// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell<br/>
        /// copies of the Software, and to permit persons to whom the Software is<br/>
        /// furnished to do so, subject to the following conditions:<br/>
        /// The above copyright notice and this permission notice shall be included in all<br/>
        /// copies or substantial portions of the Software.<br/>
        /// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR<br/>
        /// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,<br/>
        /// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE<br/>
        /// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER<br/>
        /// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,<br/>
        /// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE<br/>
        /// SOFTWARE.
        /// </param>
        /// <param name="featured">
        /// Example: true
        /// </param>
        public License(
            string key,
            string name,
            string? spdxId,
            string? url,
            string nodeId,
            string htmlUrl,
            string description,
            string implementation,
            global::System.Collections.Generic.IList<string> permissions,
            global::System.Collections.Generic.IList<string> conditions,
            global::System.Collections.Generic.IList<string> limitations,
            string body,
            bool featured)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.SpdxId = spdxId ?? throw new global::System.ArgumentNullException(nameof(spdxId));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Implementation = implementation ?? throw new global::System.ArgumentNullException(nameof(implementation));
            this.Permissions = permissions ?? throw new global::System.ArgumentNullException(nameof(permissions));
            this.Conditions = conditions ?? throw new global::System.ArgumentNullException(nameof(conditions));
            this.Limitations = limitations ?? throw new global::System.ArgumentNullException(nameof(limitations));
            this.Body = body ?? throw new global::System.ArgumentNullException(nameof(body));
            this.Featured = featured;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="License" /> class.
        /// </summary>
        public License()
        {
        }
    }
}
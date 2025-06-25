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
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// Example: MIT License
        /// </summary>
        /// <example>MIT License</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Example: MIT
        /// </summary>
        /// <example>MIT</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("spdx_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? SpdxId { get; set; }

        /// <summary>
        /// Example: https://api.github.com/licenses/mit
        /// </summary>
        /// <example>https://api.github.com/licenses/mit</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Url { get; set; }

        /// <summary>
        /// Example: MDc6TGljZW5zZW1pdA==
        /// </summary>
        /// <example>MDc6TGljZW5zZW1pdA==</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// Example: http://choosealicense.com/licenses/mit/
        /// </summary>
        /// <example>http://choosealicense.com/licenses/mit/</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// Example: A permissive license that is short and to the point. It lets people do anything with your code with proper attribution and without warranty.
        /// </summary>
        /// <example>A permissive license that is short and to the point. It lets people do anything with your code with proper attribution and without warranty.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Example: Create a text file (typically named LICENSE or LICENSE.txt) in the root of your source code and copy the text of the license into the file. Replace [year] with the current year and [fullname] with the name (or names) of the copyright holders.
        /// </summary>
        /// <example>Create a text file (typically named LICENSE or LICENSE.txt) in the root of your source code and copy the text of the license into the file. Replace [year] with the current year and [fullname] with the name (or names) of the copyright holders.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("implementation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Implementation { get; set; }

        /// <summary>
        /// Example: [commercial-use, modifications, distribution, sublicense, private-use]
        /// </summary>
        /// <example>[commercial-use, modifications, distribution, sublicense, private-use]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Permissions { get; set; }

        /// <summary>
        /// Example: [include-copyright]
        /// </summary>
        /// <example>[include-copyright]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("conditions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Conditions { get; set; }

        /// <summary>
        /// Example: [no-liability]
        /// </summary>
        /// <example>[no-liability]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("limitations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Limitations { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Body { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("featured")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Featured { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
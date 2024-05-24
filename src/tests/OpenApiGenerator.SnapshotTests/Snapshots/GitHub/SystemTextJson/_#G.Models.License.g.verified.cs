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
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// <br/>Example: MIT License
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// <br/>Example: MIT
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spdx_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? SpdxId { get; set; }

        /// <summary>
        /// <br/>Example: https://api.github.com/licenses/mit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Url { get; set; }

        /// <summary>
        /// <br/>Example: MDc6TGljZW5zZW1pdA==
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// <br/>Example: http://choosealicense.com/licenses/mit/
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// <br/>Example: A permissive license that is short and to the point. It lets people do anything with your code with proper attribution and without warranty.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// <br/>Example: Create a text file (typically named LICENSE or LICENSE.txt) in the root of your source code and copy the text of the license into the file. Replace [year] with the current year and [fullname] with the name (or names) of the copyright holders.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("implementation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Implementation { get; set; }

        /// <summary>
        /// <br/>Example: [commercial-use, modifications, distribution, sublicense, private-use]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Permissions { get; set; }

        /// <summary>
        /// <br/>Example: [include-copyright]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conditions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Conditions { get; set; }

        /// <summary>
        /// <br/>Example: [no-liability]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limitations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Limitations { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Body { get; set; }

        /// <summary>
        /// <br/>Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("featured")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Featured { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}